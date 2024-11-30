using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts.Controllers;
using TravelExperts.Models.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelExperts.Views
{
    public partial class ProductSuppliesForm : Form
    {
        public ProductSuppliesForm()
        {
            InitializeComponent();
        }

        //global variables
        List<Product> products = new List<Product>();
        List<Supplier> suppliers = new List<Supplier>();

        private void ProductSuppliesForm_Load(object sender, EventArgs e)
        {
            //clear values
            searchTB.Clear();
            ShowHideForm(true);
            //reset values
            products = new List<Product>();
            suppliers = new List<Supplier>();

            //delete existing list
            travelServicesLB.Items.Clear();
            supplierLB.Items.Clear();

            //get latest values
            products = ProductSuppliesController.getAllProducts();
            suppliers = ProductSuppliesController.getAllSuppliers();

            //onload load all product and suppliers 
            foreach (Product it in products)
            {
                //adding as keyvalue pair for
                travelServicesLB.Items.Add
                    (new KeyValuePair<int, string>
                    (it.ProductId, it.ProdName));
                travelServicesLB.DisplayMember = "Value"; // Display the ProdName
                travelServicesLB.ValueMember = "Key";    // Use the ProdId as the value
            }
            foreach (Supplier it in suppliers)
            {
                supplierLB.Items.Add
                     (new KeyValuePair<int, string>
                     (it.SupplierId, it.SupName));
                supplierLB.DisplayMember = "Value"; // Display the SupName
                supplierLB.ValueMember = "Key";    // Use the SupplierId as the value

            }


        }

        //displays or hides editable form
        private void ShowHideForm(bool hide)
        {
            if (hide)
            {
                suppliersTB.Visible = false;
                suppliersLbl.Visible = false;
                travelServiceLbl.Visible = false;
                travelServicesCBx.Visible = false;
                saveBtn.Visible = false;
                resetBtn.Visible = false;
            }
            else
            {
                suppliersTB.Visible = true;
                suppliersLbl.Visible = true;
                travelServiceLbl.Visible = true;
                travelServicesCBx.Visible = true;
                saveBtn.Visible = true;
                resetBtn.Visible = true;
            }
        }

        private void travelServicesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            if (travelServicesLB.SelectedItem != null)
            {
                //clear current supplier items
                supplierLB.Items.Clear();

                //new way to find id using keyvalue pair
                var selectedProduct = (dynamic)travelServicesLB.SelectedItem;
                var productId = selectedProduct.Key; // Access Key
                var productName = selectedProduct.Value; // Access Value
                //'!' coz we know its not null from above validation
                //string curItem = travelServicesLB.SelectedItem.ToString()!;
                //int productId = products.Find(p => p.ProdName == curItem)!.ProductId;
                if (productId > 0)
                {
                    List<Supplier> suppliers = ProductSuppliesController.getSuppliersByProductId(productId);
                    if (suppliers.IsNullOrEmpty())
                    {
                        MessageBox.Show($"No Suppliers found for: {productName} click add/update to add new supplier",
                            "No Item Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }
                    foreach (Supplier s in suppliers)
                    {
                        supplierLB.Items.Add
                        (new KeyValuePair<int, string>(s.SupplierId, s.SupName));
                        supplierLB.DisplayMember = "Value"; // Display the SupName
                        supplierLB.ValueMember = "Key";    // Use the SupplierId as the value

                    }
                }
            }
        }

        //search method that searchs in product and suppliers table
        private void searchTB_KeyUp(object sender, KeyEventArgs e)
        {
            //clear before updating
            travelServicesLB.Items.Clear();
            supplierLB.Items.Clear();


            //if not empty or not null search
            if (!string.IsNullOrEmpty(searchTB.Text))
            {
                //keeping searched text and values to lower case to match being case insensitive
                string searchLowerCase = searchTB.Text.ToLower();

                //i am searching on global models that i have created after initializing
                //i am not calling db as i already have values that i need
                //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-8.0
                var searchedProdNames = products
                    .Where(p => p.ProdName.ToLower().Contains(searchLowerCase))
                    .Select(p => new { Key = p.ProductId, Value = p.ProdName }).ToArray();

                var searchedSupNames = suppliers
                    .Where(s => s.SupName.ToLower().Contains(searchLowerCase))
                    .Select(s => new { Key = s.SupplierId, Value = s.SupName }).ToArray();

                travelServicesLB.Items.AddRange(searchedProdNames);
                supplierLB.Items.AddRange(searchedSupNames);

            }
            else//else keep default listbox values
            {
                foreach (Product it in products)
                {
                    //adding as keyvalue pair for
                    travelServicesLB.Items.Add
                        (new KeyValuePair<int, string>(it.ProductId, it.ProdName));
                    travelServicesLB.DisplayMember = "Value"; // Display the ProdName
                    travelServicesLB.ValueMember = "Key";    // Use the ProdId as the value
                }
                foreach (Supplier it in suppliers)
                {
                    supplierLB.Items.Add
                         (new KeyValuePair<int, string>(it.SupplierId, it.SupName));
                    supplierLB.DisplayMember = "Value"; // Display the SupName
                    supplierLB.ValueMember = "Key";    // Use the SupplierId as the value

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// display editable options to add/update values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            //ProductSuppliesForm_Load(sender, e);
            ShowHideForm(false);//false is !hide

            travelServicesCBx.DisplayMember = "Value";//holds prodName
            travelServicesCBx.ValueMember = "Key";//holds prodId
            //load productsname and id into combobox as key value pair
            foreach (var product in products)
            {
                travelServicesCBx.Items.Add(new KeyValuePair<int, string>(product.ProductId, product.ProdName));
            }
            //travelServicesCBx.Items.AddRange(
            //    products.Select(p=>p.ProdName)//selecting only names and adds them into cbx
            //    .ToArray());

            //check if supplier selected 
            //if true insert that value in form
            if (supplierLB.SelectedIndex > -1)
            {
                var selectedProduct = (dynamic)supplierLB.SelectedItem;

                var supID = selectedProduct.Key; // Access Key
                var supName = selectedProduct.Value; // Access Value

                //storing supid in hidden lbl
                hiddenLblSupID.Text = Convert.ToString(supID);

                suppliersTB.Text = supName;

                //get product name of that supplier
                if (supID != null)
                {
                    Product p = ProductSuppliesController.getProductBySupplierId(supID);
                    if (p != null)
                    {
                        int index = travelServicesCBx.FindString(p.ProdName);
                        if (index != -1) // Ensure the item exists in the ComboBox
                        {
                            travelServicesCBx.SelectedIndex = index;
                        }
                        else
                        {
                            MessageBox.Show("Product not found in the list.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No product found for the given supplier ID.");
                    }
                }
            }

        }

        //resets the form
        private void resetBtn_Click(object sender, EventArgs e)
        {
            ShowHideForm(true);//true is hide
            travelServicesCBx.Items.Clear();
            suppliersTB.Clear();
            hiddenLblSupID.Text = "";
        }

        /// <summary>
        /// new or update existing records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //validate form
            string suppName = suppliersTB.Text.Trim();
            string prodName="";
            int productId=0;
            if (travelServicesCBx.SelectedItem != null)
            {
            var selectedProduct = (dynamic)travelServicesCBx.SelectedItem;
            productId = selectedProduct.Key;
            prodName = selectedProduct.Value;
            }

            // Regex to allow only alphanumeric characters and spaces
            Regex regex = new Regex("^[a-zA-Z0-9 ]*$");

            // TextBox validation
            if (string.IsNullOrWhiteSpace(suppName)
                || !regex.IsMatch(suppName))
            {
                MessageBox.Show("Text field cannot be empty or have any special characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //cbx validation
            if (string.IsNullOrWhiteSpace(prodName))
            {
                MessageBox.Show("Please select a value from the combo box.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //save in products, suppliers,product_suppliers
            //if already exists update else add

            //i have stored supid in a hidden
            //field in addUpdateBtn_click method
            string supIdStr = hiddenLblSupID.Text;

            Supplier s = new Supplier();
            Product p = new Product();

            //store values to prod n supp
            s.SupName = suppName;
            p.ProdName = prodName;
            p.ProductId = productId;

            //check if hidden supid 
            //if true ie it exists so update
            if (!string.IsNullOrWhiteSpace(supIdStr))
            {
                int supId = Convert.ToInt32(supIdStr);
                s = ProductSuppliesController
                    .getSupplierBySupplierId(supId);
                //updating supname
                s.SupName = suppName;


                //get the name of product from supplier
                p = ProductSuppliesController
                    .getProductBySupplierId(supId);

                //updating prodname
                p.ProdName = prodName;
                p.ProductId = productId;
            }

            //if supid present updates
            //else passes empty supplier and product model objects
            //this adds into db instead of update
            int rowsAffected = ProductSuppliesController
                .AddOrUpdateProdSupp(s, p);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Data saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                ProductSuppliesForm_Load(sender, e);//refresh data
            }
            else
            {
                MessageBox.Show($"Error saving data",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //check if supplier selected
            if (supplierLB.SelectedItems.Count > 0)
            {
                var selectedSupplier = (dynamic)supplierLB.SelectedItem;
                int supId = selectedSupplier.Key;
                string supName = selectedSupplier.Value;
                //check if supplier has any packages that are in future
                BookingDetail bd = BookingDetailsController.GetFirstUpcomingBooking(supId);
                //this bd can also be used to display what all packages are booked in future
                if (bd != null)
                {
                    MessageBox.Show($"Cannot delete {supName} as some of their packages are booked by customers",
                        "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProductSuppliesForm_Load(sender, e);
                    return;
                }
                DialogResult dr = MessageBox.Show($"Do you want to delete: {supName}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    int resutlt = ProductSuppliesController.deleteSupplierById(supId);
                    if (resutlt > 0)
                    {
                        MessageBox.Show($"Successfully Deleted: {supName}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ProductSuppliesForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show($"error deleting: {supName}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Supplier Not Selected, Please select a supplier to delete",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
