/*
Author :: η℩.cαηtor ↈ
Co-Author :: ⌈𝗆𝖾𝗍𝖺𝖼𝗈𝖽𝖺⌋ ⊛

File :: ValidationUtils, Version 2.26
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Validation
{
    public static class ValidationUtils
    {
        // Centralized error handling (refactored to return a default boolean value)
        private static bool HandleError(string functionName, object expectedType, object actualValue)
        {
            string errorMsg = $"Function {functionName} failed: Expected type {expectedType}, but received type {actualValue?.GetType()}. Value: {actualValue}";
            Console.WriteLine(errorMsg);
            return false;
        }

        // General-purpose predicate-based validation for any type.
        public static bool ValidateWithPredicate(object value, object predicate)
        {
            if (predicate == null || predicate is not Func<object, bool> castPredicate)
            {
                return HandleError(nameof(ValidateWithPredicate), "Func<object, bool>", predicate);
            }
            return castPredicate(value);
        }

        // Checks if a given reference type value is null.
        public static bool IsNull(object value) => value == null;

        // Checks if a given reference type value is the default value.
        public static bool IsDefault<T>(T value)
        {
            return EqualityComparer<T>.Default.Equals(value, default(T));
        }

        // Checks if a collection is empty (not null, but has no elements).
        public static bool IsCollectionEmpty(object value)
        {
            if (value is not ICollection collection)
            {
                return HandleError(nameof(IsCollectionEmpty), "ICollection", value);
            }
            return collection.Count == 0;
        }

        // Checks if an enumerable is empty (not null, but has no elements).
        public static bool IsEnumerableEmpty(object value)
        {
            if (value is not IEnumerable enumerable)
            {
                return HandleError(nameof(IsEnumerableEmpty), "IEnumerable", value);
            }
            return !enumerable.Cast<object>().Any();
        }

        // General IsEmpty function that delegates to the appropriate specific function.
        public static bool IsEmpty(object value)
        {
            if (value == null)
            {
                return HandleError(nameof(IsEmpty), "non-null value", value);
            }
            return value switch
            {
                ICollection collection => IsCollectionEmpty(collection),
                IEnumerable enumerable => IsEnumerableEmpty(enumerable),
                _ => HandleError(nameof(IsEmpty), "Supported collection type", value)
            };
        }

        // Checks if a string matches a specified regular expression pattern.
        public static bool MatchesPattern(object input, object pattern)
        {
            if (input is not IEnumerable<char> charSequence)
            {
                return HandleError(nameof(MatchesPattern), "character sequence", input);
            }
            if (pattern is not string regexPattern || string.IsNullOrEmpty(regexPattern))
            {
                return HandleError(nameof(MatchesPattern), "non-null, non-empty string", pattern);
            }
            return Regex.IsMatch(new string(charSequence.ToArray()), regexPattern);
        }

        // Checks if a specified value is unique within a collection.
        public static bool IsUnique(object value, object collection)
        {
            if (collection is not IEnumerable enumerable)
            {
                return HandleError(nameof(IsUnique), "IEnumerable", collection);
            }
            return !enumerable.Cast<object>().Contains(value);
        }

        // Checks if a value is at a specified minimum.
        public static bool IsAtMin(object value, object min)
        {
            if (value is not IComparable castValue || min is not IComparable castMin)
            {
                return HandleError(nameof(IsAtMin), "IComparable", value);
            }
            return castValue.CompareTo(castMin) == 0;
        }

        // Checks if a value is greater than a specified minimum.
        public static bool IsGreaterThan(object value, object min)
        {
            if (value is not IComparable castValue || min is not IComparable castMin)
            {
                return HandleError(nameof(IsGreaterThan), "IComparable", value);
            }
            return castValue.CompareTo(castMin) > 0;
        }

        // Checks if a value is less than a specified maximum.
        public static bool IsLessThan(object value, object max)
        {
            if (value is not IComparable castValue || max is not IComparable castMax)
            {
                return HandleError(nameof(IsLessThan), "IComparable", value);
            }
            return castValue.CompareTo(max) < 0;
        }

        // Validates that all elements in a collection satisfy a specified condition.
        public static bool AllElementsMatch(object collection, object predicate)
        {
            if (collection is not IEnumerable enumerable || predicate is not Func<object, bool> castPredicate)
            {
                return HandleError(nameof(AllElementsMatch), "IEnumerable and Func<object, bool>", collection);
            }
            return enumerable.Cast<object>().All(castPredicate);
        }

        // Checks if all elements in a collection are alphabetical (works with strings or collections of strings).
        public static bool IsAlphabetical(object value)
        {
            if (value is not IEnumerable<char> charSequence)
            {
                return HandleError(nameof(IsAlphabetical), "character sequence", value);
            }
            return charSequence.All(char.IsLetter);
        }

        // Checks if all elements in a collection are numeric (works with strings or collections of strings).
        public static bool IsNumeric(object value)
        {
            if (value is not IEnumerable<char> charSequence)
            {
                return HandleError(nameof(IsNumeric), "character sequence", value);
            }
            return charSequence.All(char.IsDigit);
        }

        // Checks if a selection has been made in a selection control (e.g., ListBox, ComboBox, CheckedListBox).
        public static bool IsSelectionMade(object selectedItems)
        {
            if (selectedItems is not IEnumerable enumerable)
            {
                return HandleError(nameof(IsSelectionMade), "IEnumerable", selectedItems);
            }
            return enumerable.Cast<object>().Any();
        }

        // Checks if the length of a collection is at a specified value.
        public static bool IsLengthAtValue(object value, object length)
        {
            if (value is not IEnumerable enumerable || length is not int castLength || castLength < 0)
            {
                return HandleError(nameof(IsLengthAtValue), "IEnumerable and non-negative integer", value);
            }
            return enumerable.Cast<object>().Count() == castLength;
        }

        // Checks if a value is a defined member of an enum.
        public static bool IsValidEnumValue(object value, Type enumType)
        {
            if (enumType == null || !enumType.IsEnum || value == null)
            {
                return HandleError(nameof(IsValidEnumValue), "valid enum type and non-null value", enumType);
            }
            return Enum.IsDefined(enumType, value);
        }

        // Logs the exception details to the console.
        private static bool LogError(object ex)
        {
            if (ex is not Exception exception)
            {
                return HandleError(nameof(LogError), "Exception", ex);
            }
            Console.WriteLine($"Error in function {exception.TargetSite}: {exception.Message}\nStack Trace:\n{exception.StackTrace}");
            return false;
        }

        // Validates that the number of selected items in a selection control (e.g., ListBox, CheckedListBox) does not exceed a maximum limit.
        public static bool IsSelectionWithinLimit(object selectedItems, object maxSelections)
        {
            if (selectedItems is not IEnumerable enumerable || maxSelections is not int castMaxSelections || castMaxSelections < 0)
            {
                return HandleError(nameof(IsSelectionWithinLimit), "IEnumerable and non-negative integer", selectedItems);
            }
            return enumerable.Cast<object>().Count() <= castMaxSelections;
        }

        // Enforces a selection limit in a selection control.
        public static void UpdateSelectionLimit(object selectedItems, object maxSelections, object resetSelection)
        {
            if (selectedItems is not IEnumerable enumerable || maxSelections is not int castMaxSelections || castMaxSelections < 0 || resetSelection is not Action castResetAction)
            {
                HandleError(nameof(UpdateSelectionLimit), "IEnumerable, non-negative integer, and Action delegate", selectedItems);
                return;
            }

            if (enumerable.Cast<object>().Count() >= castMaxSelections)
            {
                castResetAction?.Invoke();
                Console.WriteLine($"Selection limit exceeded. You can only select up to {castMaxSelections} options.");
            }
        }

        // New utility methods based on extracted validation logic from views and models
        public static bool IsNotNull(object value)
        {
            return value != null;
        }

        public static bool IsGreaterThanZero(int value)
        {
            return value > 0;
        }

        public static bool IsNonNegativeDecimal(decimal value)
        {
            return value >= 0;
        }

        public static bool IsNotEmptyCollection<T>(IEnumerable<T> collection)
        {
            return collection != null && collection.Any();
        }

        public static bool ExistsInDatabase<T>(T entity, Func<T, bool> query)
        {
            // Placeholder for checking if an entity exists in a database using a query
            // Example usage: ExistsInDatabase(entity, e => e.Id == someId);
            return query(entity);
        }

        public static bool IsLengthValid(string value, int minLength, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            return value.Length >= minLength && value.Length <= maxLength;
        }

        public static bool IsValidEmail(string email)
        {
            string emailPattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";
            return MatchesPattern(email, emailPattern);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = "^\\+?[0-9]{10,15}$";
            return MatchesPattern(phoneNumber, phonePattern);
        }
    }
}
