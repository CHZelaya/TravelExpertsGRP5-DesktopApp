/*
Author :: η℩.cαηtor ↈ
Co-Author :: ⌈𝗆𝖾𝗍𝖺𝖼𝗈𝖽𝖺⌋ ⊛

File :: ValidationUtils, Version 2.18 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Validation
{
    public static class ValidationUtils
    {
        // Centralized error handling
        private static void HandleError(string functionName, object expectedType, object actualValue)
        {
            string errorMsg = $"Function {functionName} failed: Expected type {expectedType}, but received type {actualValue?.GetType()}. Value: {actualValue}";
            Console.WriteLine(errorMsg);
            throw new ArgumentException(errorMsg, nameof(actualValue));
        }

        // General-purpose predicate-based validation for any type.
        public static bool ValidateWithPredicate(object value, object predicate)
        {
            if (predicate == null)
            {
                HandleError(nameof(ValidateWithPredicate), "Func<object, bool>", predicate);
            }

            if (predicate is not Func<object, bool> castPredicate)
            {
                HandleError(nameof(ValidateWithPredicate), "Func<object, bool>", predicate);
                return false; // Added to avoid unassigned variable error
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
                HandleError(nameof(IsCollectionEmpty), "ICollection", value);
                return false; // Added to avoid unassigned variable error
            }
            return collection.Count == 0;
        }

        // Checks if an enumerable is empty (not null, but has no elements).
        public static bool IsEnumerableEmpty(object value)
        {
            if (value is not IEnumerable enumerable)
            {
                HandleError(nameof(IsEnumerableEmpty), "IEnumerable", value);
                return false; // Added to avoid unassigned variable error
            }
            return !enumerable.Cast<object>().Any();
        }

        // General IsEmpty function that delegates to the appropriate specific function.
        public static bool IsEmpty(object value)
        {
            if (value == null)
            {
                HandleError(nameof(IsEmpty), "non-null value", value);
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
                HandleError(nameof(MatchesPattern), "character sequence", input);
                return false; // Added to avoid unassigned variable error
            }
            if (pattern is not string regexPattern || string.IsNullOrEmpty(regexPattern))
            {
                HandleError(nameof(MatchesPattern), "non-null, non-empty string", pattern);
                return false; // Added to avoid unassigned variable error
            }
            return charSequence.Any() && Regex.IsMatch(new string(charSequence.ToArray()), regexPattern);
        }

        // Checks if a specified value is unique within a collection.
        public static bool IsUnique(object value, object collection)
        {
            if (collection is not IEnumerable enumerable)
            {
                HandleError(nameof(IsUnique), "IEnumerable", collection);
                return false; // Added to avoid unassigned variable error
            }
            return !enumerable.Cast<object>().Contains(value);
        }

        // Checks if a value is at a specified minimum.
        public static bool IsAtMin(object value, object min)
        {
            if (value is not IComparable castValue)
            {
                HandleError(nameof(IsAtMin), "IComparable", value);
                return false; // Added to avoid unassigned variable error
            }
            if (min is not IComparable castMin)
            {
                HandleError(nameof(IsAtMin), "IComparable", min);
                return false; // Added to avoid unassigned variable error
            }
            return castValue.CompareTo(castMin) == 0;
        }

        // Checks if a value is greater than a specified minimum.
        public static bool IsGreaterThan(object value, object min)
        {
            if (value is not IComparable castValue)
            {
                HandleError(nameof(IsGreaterThan), "IComparable", value);
                return false; // Added to avoid unassigned variable error
            }
            if (min is not IComparable castMin)
            {
                HandleError(nameof(IsGreaterThan), "IComparable", min);
                return false; // Added to avoid unassigned variable error
            }
            return castValue.CompareTo(castMin) > 0;
        }

        // Checks if a value is less than a specified maximum.
        public static bool IsLessThan(object value, object max)
        {
            if (value is not IComparable castValue)
            {
                HandleError(nameof(IsLessThan), "IComparable", value);
                return false; // Added to avoid unassigned variable error
            }
            if (max is not IComparable castMax)
            {
                HandleError(nameof(IsLessThan), "IComparable", max);
                return false; // Added to avoid unassigned variable error
            }
            return castValue.CompareTo(castMax) < 0;
        }

        // Validates that all elements in a collection satisfy a specified condition.
        public static bool AllElementsMatch(object collection, object predicate)
        {
            if (collection is not IEnumerable enumerable)
            {
                HandleError(nameof(AllElementsMatch), "IEnumerable", collection);
                return false; // Added to avoid unassigned variable error
            }
            if (predicate is not Func<object, bool> castPredicate)
            {
                HandleError(nameof(AllElementsMatch), "Func<object, bool>", predicate);
                return false; // Added to avoid unassigned variable error
            }
            return enumerable.Cast<object>().All(castPredicate);
        }

        // Checks if all elements in a collection are alphabetical (works with strings or collections of strings).
        public static bool IsAlphabetical(object value)
        {
            if (value is not IEnumerable<char> charSequence)
            {
                HandleError(nameof(IsAlphabetical), "character sequence", value);
                return false; // Added to avoid unassigned variable error
            }
            return charSequence.All(char.IsLetter);
        }

        // Checks if all elements in a collection are numeric (works with strings or collections of strings).
        public static bool IsNumeric(object value)
        {
            if (value is not IEnumerable<char> charSequence)
            {
                HandleError(nameof(IsNumeric), "character sequence", value);
                return false; // Added to avoid unassigned variable error
            }
            return charSequence.All(char.IsDigit);
        }

        // Checks if a selection has been made in a selection control (e.g., ListBox, ComboBox, CheckedListBox).
        public static bool IsSelectionMade(object selectedItems)
        {
            if (selectedItems is not IEnumerable enumerable)
            {
                HandleError(nameof(IsSelectionMade), "IEnumerable", selectedItems);
                return false; // Added to avoid unassigned variable error
            }
            return enumerable.Cast<object>().Any();
        }

        // Checks if the length of a collection is at a specified value.
        public static bool IsLengthAtValue(object value, object length)
        {
            if (value is not IEnumerable enumerable)
            {
                HandleError(nameof(IsLengthAtValue), "IEnumerable", value);
                return false; // Added to avoid unassigned variable error
            }
            if (length is not int castLength || castLength < 0)
            {
                HandleError(nameof(IsLengthAtValue), "non-negative integer", length);
                return false; // Added to avoid unassigned variable error
            }
            return enumerable.Cast<object>().Count() == castLength;
        }

        // Checks if a value is a defined member of an enum.
        public static bool IsValidEnumValue(object value, Type enumType)
        {
            if (enumType == null || !enumType.IsEnum)
            {
                HandleError(nameof(IsValidEnumValue), "valid enum type", enumType);
                return false; // Added to avoid unassigned variable error
            }
            if (value == null)
            {
                HandleError(nameof(IsValidEnumValue), "non-null value", value);
                return false; // Added to avoid unassigned variable error
            }
            return Enum.IsDefined(enumType, value);
        }

        // Logs the exception details to the console.
        private static void LogError(object ex)
        {
            if (ex is not Exception exception)
            {
                HandleError(nameof(LogError), "Exception", ex);
                return; // Added to avoid unassigned variable error
            }
            Console.WriteLine($"Error in function {exception.TargetSite}: {exception.Message}\nStack Trace:\n{exception.StackTrace}");
        }

        // Validates that the number of selected items in a selection control (e.g., ListBox, CheckedListBox) does not exceed a maximum limit.
        public static bool IsSelectionWithinLimit(object selectedItems, object maxSelections)
        {
            if (selectedItems is not IEnumerable enumerable)
            {
                HandleError(nameof(IsSelectionWithinLimit), "IEnumerable", selectedItems);
                return false; // Added to avoid unassigned variable error
            }
            if (maxSelections is not int castMaxSelections || castMaxSelections < 0)
            {
                HandleError(nameof(IsSelectionWithinLimit), "non-negative integer", maxSelections);
                return false; // Added to avoid unassigned variable error
            }
            return enumerable.Cast<object>().Count() <= castMaxSelections;
        }

        // Enforces a selection limit in a selection control.
        public static void UpdateSelectionLimit(object selectedItems, object maxSelections, object resetSelection)
        {
            if (selectedItems is not IEnumerable enumerable)
            {
                HandleError(nameof(UpdateSelectionLimit), "IEnumerable", selectedItems);
                return; // Added to avoid unassigned variable error
            }
            if (maxSelections is not int castMaxSelections || castMaxSelections < 0)
            {
                HandleError(nameof(UpdateSelectionLimit), "non-negative integer", maxSelections);
                return; // Added to avoid unassigned variable error
            }
            if (resetSelection is not Action castResetAction)
            {
                HandleError(nameof(UpdateSelectionLimit), "Action delegate", resetSelection);
                return; // Added to avoid unassigned variable error
            }

            if (enumerable.Cast<object>().Count() >= castMaxSelections)
            {
                castResetAction?.Invoke();
                Console.WriteLine($"Selection limit exceeded. You can only select up to {castMaxSelections} options.");
            }
        }
    }
}
