using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class PackageMaintenance : Form
    {
        List<PackageDTO>? packages;
        Package? CurrentPackage = null;
        public PackageMaintenance()
        {
            InitializeComponent();
        }

        private void DisplayPackageList(bool isQuery)
        {
            packages = null;
            packageList.Columns.Clear();
            if (isQuery) {
                decimal? basePrice;
                if(txt_BasePrice.Text == "")
                {
                    basePrice = null;
                } else
                {
                    basePrice = Convert.ToDecimal(txt_BasePrice.Text);
                }
                DateTime? startDate,endDate;
                if (Start_Date.Checked)
                {
                    startDate = Start_Date.Value;
                } else
                {
                    startDate = null;
                }
                if (End_Date.Checked)
                {
                    endDate = End_Date.Value;
                }
                else
                {
                    endDate = null;
                }
                packages = PackageController.GetPackagesByQuery(txt_pkgName.Text, startDate, endDate, basePrice);
            } else
            {
                packages = PackageController.GetPackages();
            }
            
            packageList.DataSource = packages;

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            packageList.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            packageList.Columns.Add(deleteColumn);

            DataGridViewButtonColumn detailColumn = new DataGridViewButtonColumn();
            detailColumn.Name = "Detail";
            detailColumn.Text = "Detail";
            detailColumn.UseColumnTextForButtonValue = true;
            packageList.Columns.Add(detailColumn);
            packageList.Columns["PkgAgencyCommission"].Width = 150;
            packageList.Columns["PkgName"].Width = 150;
            packageList.Columns["PkgDesc"].Width = 150;
            packageList.Columns["PackageId"].Visible = false;
        }

        private void PackageMaintenance_Load(object sender, EventArgs e)
        {
            DisplayPackageList(false);
        }

        private void btn_GetPackages_Click(object sender, EventArgs e)
        {

            if (ValidatorForPackage.ValidateStartDate(Start_Date) &&
                ValidatorForPackage.ValidateEndDate(End_Date, Start_Date.Value) &&
                ValidatorForPackage.IsNonNegativeDecimalForSearch(txt_BasePrice))
            {
                DisplayPackageList(true);
            }
        }

        private void packageList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (packageList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                CurrentPackage = new Package()
                {
                    PackageId = packages[e.RowIndex].PackageId,
                    PkgName = packages[e.RowIndex].PkgName,
                    PkgDesc = packages[e.RowIndex].PkgDesc,
                    PkgStartDate = packages[e.RowIndex].PkgStartDate,
                    PkgEndDate = packages[e.RowIndex].PkgEndDate,
                    PkgBasePrice = packages[e.RowIndex].PkgBasePrice,
                    PkgAgencyCommission = packages[e.RowIndex].PkgAgencyCommission,
                };
                if (e.ColumnIndex == 7)
                {
                    EditPackage(e.RowIndex);
                }
                else if (e.ColumnIndex == 8)
                {
                    DeletePackage(e.RowIndex);
                }
                else
                {
                    EnterPackageDetail(e.RowIndex);
                }
            }
        }

        private void EnterPackageDetail(int rowIndex)
        {
            PackageDetail detailForm = new PackageDetail();
            detailForm.selectPackage = CurrentPackage;
            DialogResult result = detailForm.ShowDialog();
        }

        private void EditPackage(int rowIndex)
        {
            PackageForm modifyPackage = new PackageForm();
            modifyPackage.isAdd = false;
            Package oldPackage = CloneCurrentPackage();
            modifyPackage.package = CurrentPackage;
            DialogResult result = modifyPackage.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    if (modifyPackage.package != null)
                    {
                        if (PackageController.ModifyPackage(oldPackage.PackageId, modifyPackage.package))
                        {
                            resetSearchForm();
                        }
                        else
                        {
                            MessageBox.Show("Updated Package Failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while modifying package:" + ex.Message);
                }
            }
        }

        private void DeletePackage(int rowIndex)
        {
            var PackageId = packages[rowIndex].PackageId;
            DialogResult answer = MessageBox.Show(
                    $"Do you want to delete Package:{packages[rowIndex].PkgName}?",
                    "Conform Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                CurrentPackage = null;
                try
                {
                    if (PackageController.DeletePackage(PackageId))
                    {
                        resetSearchForm();
                    }
                    else
                    {
                        MessageBox.Show("Deleted package Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while delete package:" + ex.Message);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            PackageForm addPackage = new PackageForm();
            addPackage.isAdd = true;
            addPackage.package = null;
            DialogResult result = addPackage.ShowDialog();
            if (result == DialogResult.OK)
            {
                CurrentPackage = addPackage.package;
                try
                {
                    if (CurrentPackage != null)
                    {
                        PackageController.AddPackage(CurrentPackage);
                        resetSearchForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding package:" + ex.Message);
                }
            }
        }

        private Package CloneCurrentPackage()
        {
            if (CurrentPackage == null) return null;
            Package clone = new Package()
            {
                PackageId = CurrentPackage.PackageId,
                PkgName = CurrentPackage.PkgName,
                PkgDesc = CurrentPackage.PkgDesc,
                PkgStartDate = CurrentPackage.PkgStartDate,
                PkgEndDate = CurrentPackage.PkgEndDate,
                PkgBasePrice = CurrentPackage.PkgBasePrice,
                PkgAgencyCommission = CurrentPackage.PkgAgencyCommission,
            };
            return clone;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetSearchForm();
        }

        private void resetSearchForm()
        {
            txt_pkgName.Text = "";
            Start_Date.Value = DateTime.Now;
            Start_Date.Checked = false;
            End_Date.Value = DateTime.Now;
            End_Date.Checked = false;
            txt_BasePrice.Text = "";
            DisplayPackageList(false);
        }
    }
}
