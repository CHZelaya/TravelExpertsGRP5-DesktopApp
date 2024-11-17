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
    public partial class PackageDetail : Form
    {
        public Package? selectPackage = null;
        List<PackageDetailDTO>? packageDetails;
        List<ProductsSupplierDTO>? productsSuppliers;
        public PackageDetail()
        {
            InitializeComponent();
        }

        private void DisplayPackageDetails()
        {
            if (selectPackage != null)
            {
                PackageDetailList.Items.Clear();
                txt_PkgName.Text = selectPackage.PkgName;
                txt_StartDate.Text = selectPackage.PkgStartDate.ToString();
                txt_EndDate.Text = selectPackage.PkgEndDate.ToString();
                txt_PkgDesc.Text = selectPackage.PkgDesc;
                txt_BasePrice.Text = selectPackage.PkgBasePrice.ToString();
                txt_AgencyCommission.Text = selectPackage.PkgAgencyCommission.ToString();
                packageDetails = PackageSupplierController.getDetailsByPackageId(selectPackage.PackageId);
                foreach (var detail in packageDetails)
                {
                    string fromattedText = $"ProName:{detail.ProName},        SupplierName:{detail.SupName}.";
                    PackageDetailList.Items.Add(fromattedText);
                }
            }
        }

        private void PackageDetail_Load(object sender, EventArgs e)
        {
            DisplayPackageDetails();
            loadProductSuppliers();
        }

        private void loadProductSuppliers()
        {
            productsSuppliers = PackageSupplierController.GetProductsSuppliers();
            Select_ProductSupplier.DataSource = productsSuppliers;
            Select_ProductSupplier.DisplayMember = "DisplayInfo";
            Select_ProductSupplier.ValueMember = "ProductSupplierId";
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (PackageDetailList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a detail ProductSupplier");
            }
            else
            {
                DialogResult answer = MessageBox.Show($"Do you want to remove detail: " +
                    $"Product:{packageDetails[PackageDetailList.SelectedIndex].ProName}," +
                    $"Supplier:{packageDetails[PackageDetailList.SelectedIndex].SupName}?",
                    "Conform Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        PackageSupplierController.DeletePackageProductSupplier(packageDetails[PackageDetailList.SelectedIndex].PackageProductSupplierId);
                        DisplayPackageDetails();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while remove detail of Package:" + ex.Message);
                    }
                }
            }

        }

        private void txt_Add_Click(object sender, EventArgs e)
        {
            var SelectIndex = Select_ProductSupplier.SelectedIndex;
            DialogResult answer = MessageBox.Show($"Do you want to add detail: {productsSuppliers[SelectIndex].DisplayInfo}",
                    "Conform Add", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    PackagesProductsSupplier addPackageDetail = new PackagesProductsSupplier();
                    addPackageDetail.PackageId = selectPackage.PackageId;
                    addPackageDetail.ProductSupplierId = productsSuppliers[SelectIndex].ProductSupplierId;
                    //MessageBox.Show($"ProductSupplierId:{addPackageDetail.ProductSupplierId},PackageId:{addPackageDetail.PackageId}");
                    PackageSupplierController.addNewProductSupplier(addPackageDetail);
                    DisplayPackageDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while add detail of Package:" + ex.Message);
                }
            }
        }
    }
}
