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
                travelServicesLB.Items.Add(it.ProdName);
            }
            foreach (Supplier it in suppliers)
            {
                supplierLB.Items.Add(it.SupName);
            }


        }

        private void travelServicesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            if (travelServicesLB.SelectedItem != null)
            {
                //clear current supplier items
                supplierLB.Items.Clear();

                //'!' coz we know its not null from above validation
                string curItem = travelServicesLB.SelectedItem.ToString()!;
                int productId = products.Find(p => p.ProdName == curItem)!.ProductId;
                if (productId > 0)
                {
                    List<Supplier> suppliers = ProductSuppliesController.getSuppliersByProductId(productId);
                    foreach (Supplier s in suppliers)
                    {
                        supplierLB.Items.Add(s.SupName);
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
                string[] searchedProdNames = products
                    .Where(p => p.ProdName.ToLower().Contains(searchLowerCase))
                    .Select(p => p.ProdName).ToArray();

                string[] searchedSupNames = suppliers
                    .Where(s => s.SupName.ToLower().Contains(searchLowerCase))
                    .Select(s => s.SupName).ToArray();

                travelServicesLB.Items.AddRange(searchedProdNames);
                supplierLB.Items.AddRange(searchedSupNames);

            }
            else//else keep default listbox values
            {
                foreach (Product it in products)
                {
                    travelServicesLB.Items.Add(it.ProdName);
                }
                foreach (Supplier it in suppliers)
                {
                    supplierLB.Items.Add(it.SupName);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
