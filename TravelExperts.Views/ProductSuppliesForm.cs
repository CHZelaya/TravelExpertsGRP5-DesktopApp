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

        private void ProductSuppliesForm_Load(object sender, EventArgs e)
        {
            //productID auto-increment
            //ProductSupplierId auto-increment
            //SupplierId is not auto increment

            //onload load the service types           

            foreach (Product it in products)
            {
                travelServicesLB.Items.Add(it.ProdName);
            }
        }

        private void travelServicesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            if (travelServicesLB.SelectedItem != null)
            {
                //clear current supplier items
                supplierLB.Items.Clear();

                string curItem = travelServicesLB.SelectedItem.ToString()!;
                //'!' coz we know its not null from above validation
                int productId = products.Find(p => p.ProdName == curItem).ProductId;
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
    }
}
