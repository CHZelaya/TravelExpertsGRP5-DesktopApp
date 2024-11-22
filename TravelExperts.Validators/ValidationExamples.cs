/*
Author :: η℩.cαηtor ↈ
Co-Author :: ⌈𝗆𝖾𝗍𝖺𝖼𝗈𝖽𝖺⌋ ⊛


File :: ValidationExamples, Version 1
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Assuming ValidationUtils is in the same namespace or imported

class ValidationExamples
{
    static void Main(string[] args)
    {
        // Null and Default Checks
        string nullString = null;
        bool isNull = ValidationUtils.IsNull(nullString);
        Console.WriteLine($"Is Null: {isNull}");

        int defaultValue = default(int);
        bool isNotNullOrDefault = ValidationUtils.IsNotNullOrDefault(defaultValue);
        Console.WriteLine($"Is Not Null or Default: {isNotNullOrDefault}");

        // Empty and Null/Empty Checks
        string emptyString = "";
        bool isEmpty = ValidationUtils.IsEmpty(emptyString);
        Console.WriteLine($"Is Empty: {isEmpty}");

        string nonEmptyString = "Hello";
        bool isNullOrEmpty = ValidationUtils.IsNullOrEmpty(nonEmptyString);
        Console.WriteLine($"Is Null or Empty: {isNullOrEmpty}");

        // Pattern Matching
        string email = "example@email.com";
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        bool matchesPattern = ValidationUtils.MatchesPattern(email, emailPattern);
        Console.WriteLine($"Matches Pattern: {matchesPattern}");

        // Range and Boundary Checks
        int number = 10;
        int min = 1;
        int max = 20;
        bool isAtMin = ValidationUtils.IsAtMin(number, min);
        bool isAtMax = ValidationUtils.IsAtMax(number, max);
        bool isWithinRange = ValidationUtils.IsWithinRange(number, min, max);
        Console.WriteLine($"Is At Min: {isAtMin}");
        Console.WriteLine($"Is At Max: {isAtMax}");
        Console.WriteLine($"Is Within Range: {isWithinRange}");

        // Collection Validation
        List<int> numbers = new List<int> { 2, 4, 6 };
        bool allEven = ValidationUtils.AllElementsMatch(numbers, n => n % 2 == 0);
        Console.WriteLine($"All Elements Match: {allEven}");

        // Conditional Validation
        int age = 25;
        bool isAdult = ValidationUtils.ValidateIf(age, a => a >= 18, a => a <= 65);
        Console.WriteLine($"Is Adult: {isAdult}");

        // Composite Validation
        bool allValidationsPass = ValidationUtils.ValidateAll(age, a => a >= 18, a => a <= 65, a => a % 5 == 0);
        Console.WriteLine($"All Validations Pass: {allValidationsPass}");

        // Async Validation
        Task<bool> asyncResult = ValidationUtils.ValidateAsync(age, async a => await Task.FromResult(a >= 18));
        asyncResult.ContinueWith(result => Console.WriteLine($"Async Validation Result: {result.Result}"));

        // Length Validation
        string text = "Hello, World!";
        bool isLengthInRange = ValidationUtils.IsLengthInRange(text, 5, 20);
        Console.WriteLine($"Is Length In Range: {isLengthInRange}");

        // Custom Error Messages
        bool validWithMessage = ValidationUtils.ValidateWithMessage(age, a => a >= 18, out string errorMessage, "Age must be at least 18");
        Console.WriteLine($"Validation with Message: {validWithMessage}, Error: {errorMessage}");

        // Enum Validation
        DayOfWeek day = DayOfWeek.Monday;
        bool isValidEnum = ValidationUtils.IsValidEnumValue(day);
        Console.WriteLine($"Is Valid Enum: {isValidEnum}");

        // Display Error and Custom Messages
        try
        {
            throw new Exception("Sample Exception");
        }
        catch (Exception ex)
        {
            ValidationUtils.DisplayError(ex, "A sample error occurred.");
        }
        ValidationUtils.DisplayMessage("Operation completed successfully.", "Success");

        // Selection Limit Validation for Checkboxes
        CheckedListBox clb = new CheckedListBox();
        clb.Items.Add("Option 1");
        clb.Items.Add("Option 2");
        bool withinLimit = ValidationUtils.IsSelectionWithinLimit(clb, 1);
        Console.WriteLine($"Within Selection Limit: {withinLimit}");

        // Save and Restore CheckBox States
        Dictionary<string, bool> checkboxStates = new Dictionary<string, bool>();
        ValidationUtils.SaveCheckBoxStates(clb, "MyCheckbox", checkboxStates);
        ValidationUtils.RestoreCheckBoxStates(clb, "MyCheckbox", checkboxStates);

        // Required Field Checks
        int selectedIndex = 0;
        bool selectionMade = ValidationUtils.IsSelectionMade(selectedIndex);
        Console.WriteLine($"Selection Made: {selectionMade}");

        string sampleText = "Some text";
        bool textPresent = ValidationUtils.IsTextPresent(sampleText);
        Console.WriteLine($"Text Present: {textPresent}");

        // Numeric Validations
        string decimalString = "3.14";
        bool isValidDecimal = ValidationUtils.IsDecimal(decimalString);
        Console.WriteLine($"Is Decimal: {isValidDecimal}");

        string intString = "42";
        bool isValidInt = ValidationUtils.IsInt32(intString);
        Console.WriteLine($"Is Int32: {isValidInt}");

        // Swap Example
        int a = 1, b = 2;
        ValidationUtils.Swap(ref a, ref b);
        Console.WriteLine($"Swapped Values - a: {a}, b: {b}");
    }
}
