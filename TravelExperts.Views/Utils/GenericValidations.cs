using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    
    }
}
