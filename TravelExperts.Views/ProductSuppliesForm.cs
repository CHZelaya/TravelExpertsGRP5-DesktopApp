using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        List<Product> products = ProductSuppliesController.getAllProducts();
        List<Supplier> suppliers = ProductSuppliesController.getAllSuppliers();

        private void ProductSuppliesForm_Load(object sender, EventArgs e)
        {
            //productID auto-increment
            //ProductSupplierId auto-increment
            //SupplierId is not auto increment

            //onload load all product and suppliers        

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
            resetBtn_Click(sender, e);//reset before displaying
            travelServiceLbl.Visible = true;
            suppliersLbl.Visible = true;
            travelServicesCBx.Visible = true;
            suppliersTB.Visible = true;
            //valdating tb(can replace with Cantons)

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
                var selectedProduct = (dynamic) supplierLB.SelectedItem;
                    
                var supID = selectedProduct.Key; // Access Key
                var supName = selectedProduct.Value; // Access Value

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
            suppliersTB.Text = string.Empty;
            travelServicesCBx.Items.Clear();
            travelServicesCBx.Text = string.Empty;
        }

        /// <summary>
        /// new or update existing records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
