/*
Author :: η℩.cαηtor ↈ
Co-Author :: ⌈𝗆𝖾𝗍𝖺𝖼𝗈𝖽𝖺⌋ ⊛


File :: TravelExpertsValidationExamples
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsValidationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example for Travel Packages validation

            // 1. Agency Commission should not exceed Base Price
            decimal agencyCommission = 50.0m;
            decimal basePrice = 100.0m;
            bool isCommissionValid = ValidationUtils.IsInRange(agencyCommission, 0, basePrice);
            Console.WriteLine($"Is Commission Valid: {isCommissionValid}");

            // 2. Package End Date should be later than Start Date
            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddDays(7);
            bool isDateRangeValid = ValidationUtils.ValidateIf(endDate, ed => ed > startDate, ed => ed != null);
            Console.WriteLine($"Is Date Range Valid: {isDateRangeValid}");

            // 3. Package Name and Description should not be null
            string packageName = "Vacation Package";
            string packageDescription = "All-inclusive beach vacation.";
            bool isNameValid = ValidationUtils.IsNotNullOrDefault(packageName);
            bool isDescriptionValid = ValidationUtils.IsNotNullOrDefault(packageDescription);
            Console.WriteLine($"Is Name Valid: {isNameValid}");
            Console.WriteLine($"Is Description Valid: {isDescriptionValid}");
        }
    }
}
