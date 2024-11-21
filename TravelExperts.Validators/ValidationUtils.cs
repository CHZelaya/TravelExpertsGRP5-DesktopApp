/*
Author :: η℩.cαηtor ↈ
Co-Author :: ⌈𝗆𝖾𝗍𝖺𝖼𝗈𝖽𝖺⌋ ⊛

File :: ValidationUtils, Version 2.13 (Refactored for Genericity)
*/

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public static class ValidationUtils
{
    // Checks if a given reference type value is null or its default value.
    public static bool IsNull<T>(T value) => value == null || EqualityComparer<T>.Default.Equals(value, default(T));

    // Checks if a value is not null and is not the default value.
    public static bool IsNotNullOrDefault<T>(T value) => value != null && !EqualityComparer<T>.Default.Equals(value, default);

    // Checks if a given value is empty (applicable to strings and collections).
    public static bool IsEmpty<T>(T value) => value switch
    {
        string str => string.IsNullOrEmpty(str),
        ICollection<object> collection => collection.Count == 0,
        IEnumerable<object> enumerable => !enumerable.Any(),
        _ => throw new ArgumentException("Unsupported type for IsEmpty check.")
    };

    // Checks if a given value is either null or empty.
    public static bool IsNullOrEmpty<T>(T value) => IsNull(value) || IsEmpty(value);

    // Checks if a string matches a specified regular expression pattern.
    public static bool MatchesPattern(string input, string pattern) => !string.IsNullOrEmpty(input) && Regex.IsMatch(input, pattern);

    // Checks if a specified value is unique within a collection.
    public static bool IsUnique<T>(T value, IEnumerable<T> collection) => collection == null || !collection.Contains(value);

    // Checks if a value is at or above a specified minimum.
    public static bool IsAtMin<T>(T value, T min) where T : IComparable<T> => value.CompareTo(min) >= 0;

    // Checks if a value is at or below a specified maximum.
    public static bool IsAtMax<T>(T value, T max) where T : IComparable<T> => value.CompareTo(max) <= 0;

    // Checks if a selection has been made in a control
    public static bool IsSelectionMade(int selectedIndex) => selectedIndex != -1;

    // Checks if a value is within a specified range.
    public static bool IsWithinRange<T>(T value, T min, T max) where T : IComparable<T> => IsAtMin(value, min) && IsAtMax(value, max);

    // Validates that all elements in a collection satisfy a specified condition.
    public static bool AllElementsMatch<T>(IEnumerable<T> collection, Func<T, bool> predicate) => collection != null && collection.All(predicate);

    // Conditionally validates a value based on a specified condition and validation rule.
    public static bool ValidateIf<T>(T value, Func<T, bool> condition, Func<T, bool> validationRule) => !condition(value) || validationRule(value);

    // Checks if a value meets all specified validation rules.
    public static bool ValidateAll<T>(T value, params Func<T, bool>[] validationRules) => validationRules.All(rule => rule(value));

    // Asynchronously validates a value using an async validation rule.
    public static async Task<bool> ValidateAsync<T>(T value, Func<T, Task<bool>> asyncValidationRule) => await asyncValidationRule(value);

    // Checks if the length of a string is within a specified range.
    public static bool IsLengthInRange(string value, int minLength, int maxLength) => value != null && value.Length >= minLength && value.Length <= maxLength;

    // Validates a value using a specified rule and outputs a custom error message if validation fails.
    public static bool ValidateWithMessage<T>(T value, Func<T, bool> validationRule, out string errorMessage, string customMessage = "Validation failed.")
    {
        if (validationRule == null) throw new ArgumentNullException(nameof(validationRule));
        if (!validationRule(value))
        {
            errorMessage = customMessage ?? "Validation failed.";
            return false;
        }
        errorMessage = string.Empty;
        return true;
    }

    // Checks if a value is a defined member of an enum.
    public static bool IsValidEnumValue<TEnum>(TEnum value) where TEnum : struct, Enum => Enum.IsDefined(typeof(TEnum), value);

    // Displays an error message in a message box, with optional logging.
    public static void DisplayError(Exception ex, string customMessage = "An error occurred.", bool logError = true)
    {
        if (logError) LogError(ex);
        MessageBox.Show($"{customMessage}\nError Type: {ex.GetType()}\nMessage: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    // Shows a message box with a custom message and icon.
    public static void DisplayMessage(string message, string title = "Information", MessageBoxIcon icon = MessageBoxIcon.Information) =>
        MessageBox.Show(message, title, MessageBoxButtons.OK, icon);

    // Logs the exception details to the console.
    private static void LogError(Exception ex) => Console.WriteLine($"Error: {ex.Message}\nStack Trace:\n{ex.StackTrace}");

    // Validates that the number of selected items in a CheckedListBox does not exceed a maximum limit.
    public static bool IsSelectionWithinLimit(CheckedListBox clb, int maxSelections) => clb.CheckedItems.Count <= maxSelections;

    // Enforces a selection limit in a CheckedListBox.
    public static void UpdateSelectionLimit(CheckedListBox clb, int maxSelections, ItemCheckEventArgs e)
    {
        if (e.NewValue == CheckState.Checked && clb.CheckedItems.Count >= maxSelections)
        {
            e.NewValue = CheckState.Unchecked;
            MessageBox.Show($"You can only select up to {maxSelections} options.", "Selection Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
