// Validation file to define the necessary validator method
// Daryl
namespace TravelExperts.Views
{
    public static class ValidatorForPackage
    {
        public static bool ValidateLimitString(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text == "")
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " is required");
                textBox.Focus();
            }
            else
            {
                if (textBox.Text.Length > 50)
                {
                    isValid = false;
                    MessageBox.Show(textBox.Tag + " exceeds input length of 50");
                    textBox.Focus();
                }
            }
            return isValid;
        }

        public static bool ValidateStartDate(DateTimePicker dateTimePicker)
        {
            bool isValid = true;
            DateTime selectDatetime = dateTimePicker.Value;
            if (dateTimePicker.Checked)
            {
                if (selectDatetime < DateTime.Today)
                {
                    isValid = false;
                    MessageBox.Show("The Start date for the package cannot be in the past.");
                    dateTimePicker.Focus();
                }
            }
            return isValid;
        }

        public static bool ValidateEndDate(DateTimePicker dateTimePicker, DateTime startDate)
        {
            bool isValid = true;
            DateTime selectDatetime = dateTimePicker.Value;
            if (dateTimePicker.Checked)
            {
                if (selectDatetime < startDate)
                {
                    isValid = false;
                    MessageBox.Show("The End date cannot be set before the Start Date.");
                    dateTimePicker.Focus();
                }
            }
            return isValid;
        }

        public static bool IsNonNegativeDecimal(TextBox textBox)
        {
            bool isValid = true;
            decimal result;
            if (!Decimal.TryParse(textBox.Text, out result))
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " has to be a number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (result < 0)
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " has to be positive or zero");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        public static bool IsNonNegativeDecimalForSearch(TextBox textBox)
        {
            bool isValid = true;
            decimal result;
            if (!(textBox.Text == ""))
            {
                if (!Decimal.TryParse(textBox.Text, out result))
                {
                    isValid = false;
                    MessageBox.Show(textBox.Tag + " has to be a number");
                    textBox.SelectAll();
                    textBox.Focus();
                }
                else if (result < 0)
                {
                    isValid = false;
                    MessageBox.Show(textBox.Tag + " has to be positive or zero");
                    textBox.SelectAll();
                    textBox.Focus();
                }
            }
            return isValid;
        }

        public static bool IsNonNegativeInt(TextBox textBox)
        {
            bool isValid = true;
            int result;
            if (!Int32.TryParse(textBox.Text, out result))
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " has to be a whole number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (result < 0)
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " has to be positive or zero");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }
    }
}
