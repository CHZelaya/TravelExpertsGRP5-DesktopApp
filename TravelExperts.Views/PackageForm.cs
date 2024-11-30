using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts.Models.Models;
using TravelExperts.Views.Utils;

namespace TravelExperts.Views
{
    public partial class PackageForm : Form
    {
        public Package? package;
        public bool isAdd;
        public PackageForm()
        {
            InitializeComponent();
        }

        private void PackageForm_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                this.Text = "Add Package";
            }
            else
            {
                this.Text = "Modify Package";
                DisplayPackage();
            }
        }

        private void FillPackage()
        {
            package.PkgName = txt_PkgName.Text;
            package.PkgDesc = txt_PkgDesc.Text;
            package.PkgStartDate = Pick_StartDate.Value;
            package.PkgEndDate = Pick_EndDate.Value;
            package.PkgBasePrice = Convert.ToDecimal(txt_BasePrice.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txt_AgencyCommission.Text);
        }
        private void DisplayPackage()
        {
            if (package != null)
            {
                txt_PkgName.Text = package.PkgName;
                txt_PkgDesc.Text = package.PkgDesc;
                Pick_StartDate.Value = package.PkgStartDate ?? DateTime.Now;
                Pick_EndDate.Value = package.PkgEndDate ?? DateTime.Now;
                txt_BasePrice.Text = package.PkgBasePrice.ToString();
                txt_AgencyCommission.Text = package.PkgAgencyCommission.ToString();
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (ValidatorForPackage.ValidateLimitString(txt_PkgName) &&
                ValidatorForPackage.ValidateLimitString(txt_PkgDesc) &&
                ValidatorForPackage.ValidateStartDate(Pick_StartDate) &&
                ValidatorForPackage.ValidateEndDate(Pick_EndDate,Pick_StartDate.Value) &&
                ValidatorForPackage.IsNonNegativeDecimal(txt_BasePrice) &&
                ValidatorForPackage.IsNonNegativeDecimal(txt_AgencyCommission))
            {
                if (isAdd) { 
                    package = new Package();
                    FillPackage();
                } else
                {
                    FillPackage();
                }
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
