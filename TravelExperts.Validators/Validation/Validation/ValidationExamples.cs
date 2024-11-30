/*
Author :: η℩.cαηtor ↈ
Co-Author :: ⌈𝗆𝖾𝗍𝖺𝖼𝗈𝖽𝖺⌋ ⊛

File :: ValidationExamples
*/

using System;
using System.Collections.Generic;

namespace ValidationExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Validation Examples...");

            // ValidationUtils Methods Examples:

            // ValidateWithPredicate
            Console.WriteLine("Validating with a custom predicate (even number check): " +
                              Validation.ValidationUtils.ValidateWithPredicate(4, new Func<object, bool>(x => (int)x % 2 == 0)));

            // IsNull
            Console.WriteLine("Checking if null is null: " + Validation.ValidationUtils.IsNull(null));

            // IsDefault
            Console.WriteLine("Checking if default int is default: " + Validation.ValidationUtils.IsDefault(0));

            // IsCollectionEmpty
            Console.WriteLine("Checking if empty collection is empty: " +
                              Validation.ValidationUtils.IsCollectionEmpty(new List<int>()));

            // IsEnumerableEmpty
            Console.WriteLine("Checking if empty enumerable is empty: " +
                              Validation.ValidationUtils.IsEnumerableEmpty(new List<int>()));

            // IsEmpty
            Console.WriteLine("Checking if empty string is empty: " + Validation.ValidationUtils.IsEmpty(""));

            // MatchesPattern
            Console.WriteLine("Validating email with regex pattern: " +
                              Validation.ValidationUtils.MatchesPattern("test@example.com", @"^[^@\s]+@[^@\s]+\.[^@\s]+$"));

            // IsUnique
            Console.WriteLine("Checking if element is unique in list: " +
                              Validation.ValidationUtils.IsUnique(3, new List<int> { 1, 2, 3, 4 }));

            // IsAtMin
            Console.WriteLine("Checking if value is at min: " + Validation.ValidationUtils.IsAtMin(5, 5));

            // IsGreaterThan
            Console.WriteLine("Checking if value is greater than min: " + Validation.ValidationUtils.IsGreaterThan(10, 5));

            // IsLessThan
            Console.WriteLine("Checking if value is less than max: " + Validation.ValidationUtils.IsLessThan(5, 10));

            // AllElementsMatch
            Console.WriteLine("Checking if all elements in collection are positive: " +
                              Validation.ValidationUtils.AllElementsMatch(new List<int> { 1, 2, 3, 4 }, new Func<object, bool>(x => (int)x > 0)));

            // IsAlphabetical
            Console.WriteLine("Checking if string is alphabetical: " + Validation.ValidationUtils.IsAlphabetical("HelloWorld"));

            // IsNumeric
            Console.WriteLine("Checking if string is numeric: " + Validation.ValidationUtils.IsNumeric("123456"));

            // IsSelectionMade
            Console.WriteLine("Checking if selection is made: " + Validation.ValidationUtils.IsSelectionMade(new List<int> { 1, 2, 3 }));

            // IsLengthAtValue
            Console.WriteLine("Checking if collection length matches value: " +
                              Validation.ValidationUtils.IsLengthAtValue(new List<int> { 1, 2, 3 }, 3));

            // IsValidEnumValue
            Console.WriteLine("Checking if value is valid enum member: " +
                              Validation.ValidationUtils.IsValidEnumValue(DayOfWeek.Monday, typeof(DayOfWeek)));

            // IsSelectionWithinLimit
            Console.WriteLine("Checking if selection is within limit: " +
                              Validation.ValidationUtils.IsSelectionWithinLimit(new List<int> { 1, 2 }, 3));

            // UpdateSelectionLimit
            Console.WriteLine("Updating selection limit...");
            Validation.ValidationUtils.UpdateSelectionLimit(new List<int> { 1, 2, 3 }, 2, () => Console.WriteLine("Selection has been reset."));

            // IsNotNull
            Console.WriteLine("Checking if value is not null: " + Validation.ValidationUtils.IsNotNull("NotNull"));

            // IsGreaterThanZero
            Console.WriteLine("Checking if value is greater than zero: " + Validation.ValidationUtils.IsGreaterThanZero(10));

            // IsNonNegativeDecimal
            Console.WriteLine("Checking if value is non-negative decimal: " + Validation.ValidationUtils.IsNonNegativeDecimal(5.5m));

            // IsNotEmptyCollection
            Console.WriteLine("Checking if collection is not empty: " + Validation.ValidationUtils.IsNotEmptyCollection(new List<int> { 1 }));

            // ExistsInDatabase
            Console.WriteLine("Checking if entity exists in database: " +
                              Validation.ValidationUtils.ExistsInDatabase("entity", e => e.ToString() == "entity"));

            // IsLengthValid
            Console.WriteLine("Checking if string length is valid: " + Validation.ValidationUtils.IsLengthValid("Hello", 1, 10));

            // IsValidEmail
            Console.WriteLine("Validating email: " + Validation.ValidationUtils.IsValidEmail("test@example.com"));

            // IsValidPhoneNumber
            Console.WriteLine("Validating phone number: " + Validation.ValidationUtils.IsValidPhoneNumber("+12345678901"));

            Console.WriteLine("Validation Examples Complete.");
        }
    }
}
