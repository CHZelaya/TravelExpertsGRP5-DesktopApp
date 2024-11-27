/*
Author :: η℩.cαηtor ↈ
Co-Author :: ⌈𝗆𝖾𝗍𝖺𝖼𝗈𝖽𝖺⌋ ⊛

File :: ValidationUtils, Version 2.15
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public static class ValidationUtils
{
    // General-purpose predicate-based validation for any type.
    public static bool ValidateWithPredicate(object value, object predicate)
    {
        if (predicate is not Func<object, bool> castPredicate)
        {
            string errorMsg = $"Function ValidateWithPredicate failed: Expected a predicate function, but received type {predicate?.GetType()}. Value: {value}";
            DisplayError(new ArgumentException(errorMsg, nameof(predicate)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(predicate));
        }
        return castPredicate(value);
    }

    // Checks if a given reference type value is null.
    public static bool IsNull(object value) => value == null;

    // Checks if a given reference type value is the default value.
    public static bool IsDefault(object value, object defaultValue)
    {
        if (value == null)
        {
            string errorMsg = "Function IsDefault failed: Value cannot be null.";
            DisplayError(new ArgumentNullException(nameof(value), errorMsg), errorMsg, true);
            throw new ArgumentNullException(nameof(value), errorMsg);
        }
        if (defaultValue == null)
        {
            string errorMsg = "Function IsDefault failed: Default value cannot be null.";
            DisplayError(new ArgumentNullException(nameof(defaultValue), errorMsg), errorMsg, true);
            throw new ArgumentNullException(nameof(defaultValue), errorMsg);
        }
        return EqualityComparer<object>.Default.Equals(value, defaultValue);
    }

    // Checks if a collection is empty (not null, but has no elements).
    public static bool IsCollectionEmpty(object value)
    {
        if (value is not ICollection collection)
        {
            string errorMsg = $"Function IsCollectionEmpty failed: Expected a collection, but received type {value?.GetType()}. Value: {value}";
            DisplayError(new ArgumentException(errorMsg, nameof(value)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(value));
        }
        return collection.Count == 0;
    }

    // Checks if an enumerable is empty (not null, but has no elements).
    public static bool IsEnumerableEmpty(object value)
    {
        if (value is not IEnumerable enumerable)
        {
            string errorMsg = $"Function IsEnumerableEmpty failed: Expected an enumerable, but received type {value?.GetType()}. Value: {value}";
            DisplayError(new ArgumentException(errorMsg, nameof(value)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(value));
        }
        return !enumerable.Cast<object>().Any();
    }

    // General IsEmpty function that delegates to the appropriate specific function.
    public static bool IsEmpty(object value)
    {
        if (value == null)
        {
            string errorMsg = "Function IsEmpty failed: Value cannot be null.";
            DisplayError(new ArgumentNullException(nameof(value), errorMsg), errorMsg, true);
            throw new ArgumentNullException(nameof(value), errorMsg);
        }
        return value switch
        {
            ICollection collection => IsCollectionEmpty(collection),
            IEnumerable enumerable => IsEnumerableEmpty(enumerable),
            _ => throw new ArgumentException($"IsEmpty check failed: Unsupported type {value.GetType()}. Value: {value}")
        };
    }

    // Checks if a string matches a specified regular expression pattern.
    public static bool MatchesPattern(object input, object pattern)
    {
        if (input is not IEnumerable<char> charSequence)
        {
            string errorMsg = $"Function MatchesPattern failed: Expected a character sequence, but received type {input?.GetType()}. Value: {input}";
            DisplayError(new ArgumentException(errorMsg, nameof(input)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(input));
        }
        if (pattern is not string regexPattern || string.IsNullOrEmpty(regexPattern))
        {
            string errorMsg = "Function MatchesPattern failed: Pattern must be a non-null, non-empty string.";
            DisplayError(new ArgumentException(errorMsg, nameof(pattern)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(pattern));
        }
        return charSequence.Any() && Regex.IsMatch(new string(charSequence.ToArray()), regexPattern);
    }

    // Checks if a specified value is unique within a collection.
    public static bool IsUnique(object value, object collection)
    {
        if (collection is not IEnumerable enumerable)
        {
            string errorMsg = $"Function IsUnique failed: Expected a collection, but received type {collection?.GetType()}. Value: {collection}";
            DisplayError(new ArgumentException(errorMsg, nameof(collection)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(collection));
        }
        return !enumerable.Cast<object>().Contains(value);
    }

    // Checks if a value is at a specified minimum.
    public static bool IsAtMin(object value, object min)
    {
        if (value is not IComparable castValue)
        {
            string errorMsg = $"Function IsAtMin failed: Expected a comparable value, but received type {value?.GetType()}. Value: {value}";
            DisplayError(new ArgumentException(errorMsg, nameof(value)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(value));
        }
        if (min is not IComparable castMin)
        {
            string errorMsg = $"Function IsAtMin failed: Expected a comparable minimum value, but received type {min?.GetType()}. Value: {min}";
            DisplayError(new ArgumentException(errorMsg, nameof(min)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(min));
        }
        return castValue.CompareTo(castMin) == 0;
    }

    // Checks if a value is greater than a specified minimum.
    public static bool IsGreaterThan(object value, object min)
    {
        if (value is not IComparable castValue)
        {
            string errorMsg = $"Function IsGreaterThan failed: Expected a comparable value, but received type {value?.GetType()}. Value: {value}";
            DisplayError(new ArgumentException(errorMsg, nameof(value)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(value));
        }
        if (min is not IComparable castMin)
        {
            string errorMsg = $"Function IsGreaterThan failed: Expected a comparable minimum value, but received type {min?.GetType()}. Value: {min}";
            DisplayError(new ArgumentException(errorMsg, nameof(min)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(min));
        }
        return castValue.CompareTo(castMin) > 0;
    }

    // Checks if a value is less than a specified maximum.
    public static bool IsLessThan(object value, object max)
    {
        if (value is not IComparable castValue)
        {
            string errorMsg = $"Function IsLessThan failed: Expected a comparable value, but received type {value?.GetType()}. Value: {value}";
            DisplayError(new ArgumentException(errorMsg, nameof(value)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(value));
        }
        if (max is not IComparable castMax)
        {
            string errorMsg = $"Function IsLessThan failed: Expected a comparable maximum value, but received type {max?.GetType()}. Value: {max}";
            DisplayError(new ArgumentException(errorMsg, nameof(max)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(max));
        }
        return castValue.CompareTo(castMax) < 0;
    }

    // Validates that all elements in a collection satisfy a specified condition.
    public static bool AllElementsMatch(object collection, object predicate)
    {
        if (collection is not IEnumerable enumerable)
        {
            string errorMsg = $"Function AllElementsMatch failed: Expected a collection, but received type {collection?.GetType()}. Value: {collection}";
            DisplayError(new ArgumentException(errorMsg, nameof(collection)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(collection));
        }
        if (predicate is not Func<object, bool> castPredicate)
        {
            string errorMsg = $"Function AllElementsMatch failed: Expected a predicate function, but received type {predicate?.GetType()}. Value: {predicate}";
            DisplayError(new ArgumentException(errorMsg, nameof(predicate)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(predicate));
        }
        return enumerable.Cast<object>().All(castPredicate);
    }

    // Checks if all elements in a collection are alphabetical (works with strings or collections of strings).
    public static bool IsAlphabetical(object value)
    {
        if (value is not IEnumerable<char> charSequence)
        {
            string errorMsg = $"Function IsAlphabetical failed: Expected a character sequence, but received type {value?.GetType()}. Value: {value}";
            DisplayError(new ArgumentException(errorMsg, nameof(value)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(value));
        }
        return charSequence.All(char.IsLetter);
    }

    // Checks if all elements in a collection are numeric (works with strings or collections of strings).
    public static bool IsNumeric(object value)
    {
        if (value is not IEnumerable<char> charSequence)
        {
            string errorMsg = $"Function IsNumeric failed: Expected a character sequence, but received type {value?.GetType()}. Value: {value}";
            DisplayError(new ArgumentException(errorMsg, nameof(value)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(value));
        }
        return charSequence.All(char.IsDigit);
    }

    // Checks if a selection has been made in a selection control (e.g., ListBox, ComboBox, CheckedListBox).
    public static bool IsSelectionMade(object selectedItems)
    {
        if (selectedItems is not IEnumerable enumerable)
        {
            string errorMsg = $"Function IsSelectionMade failed: Expected a collection, but received type {selectedItems?.GetType()}. Value: {selectedItems}";
            DisplayError(new ArgumentException(errorMsg, nameof(selectedItems)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(selectedItems));
        }
        return enumerable.Cast<object>().Any();
    }

    // Checks if the length of a collection is at a specified value.
    public static bool IsLengthAtValue(object value, object length)
    {
        if (value is not IEnumerable enumerable)
        {
            string errorMsg = $"Function IsLengthAtValue failed: Expected a collection, but received type {value?.GetType()}. Value: {value}";
            DisplayError(new ArgumentException(errorMsg, nameof(value)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(value));
        }
        if (length is not int castLength || castLength < 0)
        {
            string errorMsg = $"Function IsLengthAtValue failed: Length must be a non-negative integer. Received: {length}";
            DisplayError(new ArgumentException(errorMsg, nameof(length)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(length));
        }
        return enumerable.Cast<object>().Count() == castLength;
    }

    // Checks if a value is a defined member of an enum.
    public static bool IsValidEnumValue(object value, Type enumType)
    {
        if (enumType == null || !enumType.IsEnum)
        {
            string errorMsg = $"Function IsValidEnumValue failed: Provided type must be a valid enum type. Received: {enumType}";
            DisplayError(new ArgumentException(errorMsg, nameof(enumType)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(enumType));
        }
        if (value == null)
        {
            string errorMsg = "Function IsValidEnumValue failed: Value cannot be null.";
            DisplayError(new ArgumentNullException(nameof(value), errorMsg), errorMsg, true);
            throw new ArgumentNullException(nameof(value), errorMsg);
        }
        return Enum.IsDefined(enumType, value);
    }

    // Displays an error message in a message box, with optional logging.
    public static void DisplayError(object ex, object customMessage, object logError)
    {
        if (ex is not Exception exception)
        {
            string errorMsg = $"Function DisplayError failed: Expected an exception, but received type {ex?.GetType()}. Value: {ex}";
            throw new ArgumentException(errorMsg, nameof(ex));
        }
        if (customMessage is not string message)
        {
            string errorMsg = $"Function DisplayError failed: Expected a string for customMessage, but received type {customMessage?.GetType()}. Value: {customMessage}";
            throw new ArgumentException(errorMsg, nameof(customMessage));
        }
        if (logError is not bool castLogError)
        {
            string errorMsg = $"Function DisplayError failed: Expected a boolean for logError, but received type {logError?.GetType()}. Value: {logError}";
            throw new ArgumentException(errorMsg, nameof(logError));
        }

        if (castLogError)
        {
            LogError(exception);
        }
        MessageBox.Show($"{message}\nError Type: {exception.GetType()}\nMessage: {exception.Message}\nThrown by: {exception.TargetSite}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    // Shows a message box with a custom message and icon.
    public static void DisplayMessage(object message, object title, object icon)
    {
        if (message is not string castMessage || string.IsNullOrEmpty(castMessage))
        {
            string errorMsg = $"Function DisplayMessage failed: Message cannot be null or empty. Received type: {message?.GetType()} Value: {message}";
            throw new ArgumentException(errorMsg, nameof(message));
        }
        if (title is not string castTitle)
        {
            string errorMsg = $"Function DisplayMessage failed: Expected a string for title, but received type {title?.GetType()}. Value: {title}";
            throw new ArgumentException(errorMsg, nameof(title));
        }
        if (icon is not MessageBoxIcon castIcon)
        {
            string errorMsg = $"Function DisplayMessage failed: Expected a MessageBoxIcon, but received type {icon?.GetType()}. Value: {icon}";
            throw new ArgumentException(errorMsg, nameof(icon));
        }

        MessageBox.Show(castMessage, castTitle, MessageBoxButtons.OK, castIcon);
    }

    // Logs the exception details to the console.
    private static void LogError(object ex)
    {
        if (ex is not Exception exception)
        {
            string errorMsg = $"Function LogError failed: Expected an exception, but received type {ex?.GetType()}. Value: {ex}";
            throw new ArgumentException(errorMsg, nameof(ex));
        }
        Console.WriteLine($"Error in function {exception.TargetSite}: {exception.Message}\nStack Trace:\n{exception.StackTrace}");
    }

    // Validates that the number of selected items in a selection control (e.g., ListBox, CheckedListBox) does not exceed a maximum limit.
    public static bool IsSelectionWithinLimit(object selectedItems, object maxSelections)
    {
        if (selectedItems is not IEnumerable enumerable)
        {
            string errorMsg = $"Function IsSelectionWithinLimit failed: Expected a collection, but received type {selectedItems?.GetType()}. Value: {selectedItems}";
            DisplayError(new ArgumentException(errorMsg, nameof(selectedItems)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(selectedItems));
        }
        if (maxSelections is not int castMaxSelections || castMaxSelections < 0)
        {
            string errorMsg = $"Function IsSelectionWithinLimit failed: Expected a non-negative integer for maxSelections, but received type {maxSelections?.GetType()}. Value: {maxSelections}";
            DisplayError(new ArgumentException(errorMsg, nameof(maxSelections)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(maxSelections));
        }
        return enumerable.Cast<object>().Count() <= castMaxSelections;
    }

    // Enforces a selection limit in a selection control.
    public static void UpdateSelectionLimit(object selectedItems, object maxSelections, object resetSelection)
    {
        if (selectedItems is not IEnumerable enumerable)
        {
            string errorMsg = $"Function UpdateSelectionLimit failed: Expected a collection, but received type {selectedItems?.GetType()}. Value: {selectedItems}";
            DisplayError(new ArgumentException(errorMsg, nameof(selectedItems)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(selectedItems));
        }
        if (maxSelections is not int castMaxSelections || castMaxSelections < 0)
        {
            string errorMsg = $"Function UpdateSelectionLimit failed: Expected a non-negative integer for maxSelections, but received type {maxSelections?.GetType()}. Value: {maxSelections}";
            DisplayError(new ArgumentException(errorMsg, nameof(maxSelections)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(maxSelections));
        }
        if (resetSelection is not Action castResetAction)
        {
            string errorMsg = $"Function UpdateSelectionLimit failed: Expected an Action delegate for resetSelection, but received type {resetSelection?.GetType()}. Value: {resetSelection}";
            DisplayError(new ArgumentException(errorMsg, nameof(resetSelection)), errorMsg, true);
            throw new ArgumentException(errorMsg, nameof(resetSelection));
        }

        if (enumerable.Cast<object>().Count() >= castMaxSelections)
        {
            castResetAction?.Invoke();
            DisplayMessage($"You can only select up to {castMaxSelections} options.", "Selection Limit", MessageBoxIcon.Warning);
        }
    }
}
