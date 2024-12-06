namespace TravelExperts.Views.Utils
{
    /// <summary>
    /// simple validation class
    /// </summary>
    public static class GenericValidations
    {

        /// <summary>
        /// Test if there is any input from the user (empty string)
        /// </summary>
        /// <param name="textBox">textbox tpo be checked</param>
        /// <returns>true if input is non-empty, false if input is empty</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text == "") //check is there is any input
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field is empty");
                textBox.Focus();//places the cursor on the textbox
            }
            return isValid;
        }

        /// <summary>
        /// Test if the input contains non-numeric characters
        /// </summary>
        /// <param name="textBox">textbox to be tested</param>
        /// <returns>true if the input can be converted to a decimal</returns>
        public static bool IsDouble(TextBox textBox)
        {
            bool isValid = true;
            //double output;
            //tries to parse or convert text box input to decimal
            if (!Double.TryParse(textBox.Text, out double output))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field contains non-numeric charaters");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }


        /// <summary>
        /// Test if the input contains non-numeric characters
        /// </summary>
        /// <param name="textBox">textbox to be tested</param>
        /// <returns>true if the input can be converted to a integer</returns>
        public static bool IsInteger(TextBox textBox)
        {
            bool isValid = true;
            //double output;
            //tries to parse or convert text box input to decimal
            if (!Int32.TryParse(textBox.Text, out int output))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field contains non-numeric charaters");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;


        }

        public static bool IsNonNegativeInteger(TextBox textBox)
        {
            bool isValid = true;
            //double output;
            //tries to parse or convert text box input to decimal
            if (!Int32.TryParse(textBox.Text, out int output))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field contains non-numeric charaters");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (output < 0)
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field should be greater than zero");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        public static bool IsNonNegativeDouble(TextBox textBox)
        {
            bool isValid = true;
            //double output;
            //tries to parse or convert text box input to decimal
            if (!Double.TryParse(textBox.Text, out double output))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field contains non-numeric charaters");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (output < 0)
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field should be greater than zero");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }


        public static bool IsDoubleInRange(TextBox textBox, double min, double max)
        {
            bool isValid = true;
            //double output;
            //tries to parse or convert text box input to decimal
            if (!Double.TryParse(textBox.Text, out double output))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field contains non-numeric charaters");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (output < min || output > max)
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field should be within the range of {min} and {max}");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// Validates the email format of the input from the user.
        /// </summary>
        /// <param name="textBox">TextBox to be checked for email input</param>
        /// <returns>true if the email format is valid, false if the format is invalid</returns>
        public static bool IsValidEmail(TextBox textBox)
        {
            bool isValid = true;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Simple regex for email validation

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, emailPattern)) // Check if the email format is valid
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field contains an invalid email address");
                textBox.Focus(); // Places the cursor on the textbox
            }
            return isValid;
        }

        /// <summary>
        /// Validates that the input from the user contains only alphanumeric characters.
        /// </summary>
        /// <param name="textBox">TextBox to be checked for alphanumeric input</param>
        /// <returns>true if the input is alphanumeric, false if the input contains non-alphanumeric characters</returns>
        public static bool IsAlphanumericWithHyphens(TextBox textBox)
        {
            bool isValid = true;
            string input = textBox.Text;

            // Check if the input contains only alphanumeric characters and hyphens
            if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z0-9-]+$")) // Updated regex to allow hyphens
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field can only contain alphanumeric characters and hyphens (letters, numbers, and '-')");
                textBox.Focus(); // Places the cursor on the textbox
            }
            return isValid;
        }

        /// <summary>
        /// Validates the input from the user to ensure it matches North American phone number formats.
        /// </summary>
        /// <param name="textBox">TextBox to be checked for phone number input</param>
        /// <returns>true if the phone number format is valid, false if the format is invalid</returns>
        public static bool IsValidPhoneNumber(TextBox textBox)
        {
            bool isValid = true;
            string phonePattern = @"^(\+1[-. ]?)?(\(?\d{3}\)?[-. ]?)?\d{3}[-. ]?\d{4}$"; // Regex for North American phone number formats

            // Check if the input matches the phone number pattern
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, phonePattern))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field contains an invalid phone number format");
                textBox.Focus(); // Places the cursor on the textbox
            }
            return isValid;
        }

        /// <summary>
        /// Validates the input from the user to ensure it matches Canadian postal code formats.
        /// </summary>
        /// <param name="textBox">TextBox to be checked for postal code input</param>
        /// <returns>true if the postal code format is valid, false if the format is invalid</returns>
        public static bool IsValidCanadianPostalCode(TextBox textBox)
        {
            bool isValid = true;
            string postalCodePattern = @"^[A-Z]\d[A-Z]\d[A-Z]\d$"; // Regex for Canadian postal code format, no space.

            // Check if the input matches the postal code pattern
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, postalCodePattern))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be in a A0A 0A0 format ");
                textBox.Focus(); // Places the cursor on the textbox
            }
            return isValid;
        }

        /// <summary>
        /// Validates the input from the user to ensure an item is selected in the ComboBox.
        /// </summary>
        /// <param name="comboBox">ComboBox to be checked for user selection</param>
        /// <returns>true if an item is selected, false if no item is selected</returns>
        public static bool IsComboBoxPresent(ComboBox comboBox)
        {
            bool isValid = true;

            // Check if the ComboBox has a selected item
            if (comboBox.SelectedIndex == -1)
            {
                isValid = false;
                MessageBox.Show($"{comboBox.Tag} field requires a selection.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox.Focus(); // Places the cursor on the ComboBox
            }

            return isValid;
        }

        /// <summary>
        /// Validates the input from the user to ensure it contains only alphanumeric characters and spaces.
        /// </summary>
        /// <param name="textBox">TextBox to be checked for valid input</param>
        /// <returns>true if the input is valid, false if the input is invalid</returns>
        public static bool IsValidAddressInput(TextBox textBox)
        {
            bool isValid = true;
            string input = textBox.Text;

            // Check if the input contains only alphanumeric characters and spaces
            if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z0-9 ]+$")) // Regex for alphanumeric check allowing spaces
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field can only contain alphanumeric characters and spaces.");
                textBox.Focus(); // Places the cursor on the textbox
            }
            return isValid;
        }

    }
}
