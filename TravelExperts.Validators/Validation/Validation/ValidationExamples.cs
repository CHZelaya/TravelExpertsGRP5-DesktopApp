using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Validation;

public class ValidatorTestSuite
{
    public static void Main()
    {
        Console.WriteLine("Starting ValidationUtils Test Suite...\n");

        // Test ValidateWithPredicate
        try
        {
            bool result = ValidationUtils.ValidateWithPredicate(5, new Func<object, bool>(x => (int)x > 3));
            Console.WriteLine("Validating if 5 is greater than 3 using ValidateWithPredicate: Result = " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in ValidateWithPredicate: " + ex.Message);
        }

        // Test ValidateWithPredicate with incorrect type
        try
        {
            Console.WriteLine("Validating with incorrect type (string instead of Func): " + ValidationUtils.ValidateWithPredicate(5, "not a function"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in ValidateWithPredicate (incorrect type): " + ex.Message);
        }

        // Test IsNull
        Console.WriteLine("Validating if null is null using IsNull: Result = " + ValidationUtils.IsNull(null));
        Console.WriteLine("Validating if integer 5 is null using IsNull: Result = " + ValidationUtils.IsNull(5));

        // Test IsDefault
        try
        {
            Console.WriteLine("Validating if integer 5 is default using IsDefault: Result = " + ValidationUtils.IsDefault(5));
            Console.WriteLine("Validating if integer 0 is default using IsDefault: Result = " + ValidationUtils.IsDefault(0));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsDefault: " + ex.Message);
        }

        // Test IsCollectionEmpty
        try
        {
            List<int> emptyList = new List<int>();
            Console.WriteLine("Validating if an empty list is empty using IsCollectionEmpty: Result = " + ValidationUtils.IsCollectionEmpty(emptyList));
            List<int> filledList = new List<int> { 1, 2, 3 };
            Console.WriteLine("Validating if a filled list is empty using IsCollectionEmpty: Result = " + ValidationUtils.IsCollectionEmpty(filledList));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsCollectionEmpty: " + ex.Message);
        }

        // Test IsCollectionEmpty with incorrect type
        try
        {
            Console.WriteLine("Validating if integer 5 is a collection using IsCollectionEmpty: " + ValidationUtils.IsCollectionEmpty(5));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsCollectionEmpty (incorrect type): " + ex.Message);
        }

        // Test IsEnumerableEmpty
        try
        {
            IEnumerable emptyEnumerable = new List<int>();
            Console.WriteLine("Validating if an empty enumerable is empty using IsEnumerableEmpty: Result = " + ValidationUtils.IsEnumerableEmpty(emptyEnumerable));
            IEnumerable filledEnumerable = new List<int> { 1, 2, 3 };
            Console.WriteLine("Validating if a filled enumerable is empty using IsEnumerableEmpty: Result = " + ValidationUtils.IsEnumerableEmpty(filledEnumerable));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsEnumerableEmpty: " + ex.Message);
        }

        // Test IsEnumerableEmpty with incorrect type
        try
        {
            Console.WriteLine("Validating if a string is an enumerable using IsEnumerableEmpty: " + ValidationUtils.IsEnumerableEmpty("Not an enumerable"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsEnumerableEmpty (incorrect type): " + ex.Message);
        }

        // Test IsEmpty
        try
        {
            Console.WriteLine("Validating if an empty list is empty using IsEmpty: Result = " + ValidationUtils.IsEmpty(new List<int>()));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsEmpty: " + ex.Message);
        }

        // Test IsEmpty with incorrect type
        try
        {
            Console.WriteLine("Validating if integer 10 is empty using IsEmpty: " + ValidationUtils.IsEmpty(10));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsEmpty (incorrect type): " + ex.Message);
        }

        // Test MatchesPattern
        try
        {
            Console.WriteLine("Validating if 'Hello123' matches the pattern '\\d+': Result = " + ValidationUtils.MatchesPattern("Hello123", "\\d+"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in MatchesPattern: " + ex.Message);
        }

        // Test MatchesPattern with incorrect type
        try
        {
            Console.WriteLine("Validating if integer 123 matches the pattern '\\d+': " + ValidationUtils.MatchesPattern(123, "\\d+"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in MatchesPattern (incorrect type): " + ex.Message);
        }

        // Test IsUnique
        try
        {
            List<int> numbers = new List<int> { 1, 2, 3 };
            Console.WriteLine("Validating if value 4 is unique in the list using IsUnique: Result = " + ValidationUtils.IsUnique(4, numbers));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsUnique: " + ex.Message);
        }

        // Test IsUnique with incorrect type
        try
        {
            Console.WriteLine("Validating if string 'four' is unique in a list of ints using IsUnique: " + ValidationUtils.IsUnique("four", new List<int> { 1, 2, 3 }));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsUnique (incorrect type): " + ex.Message);
        }

        // Test IsAtMin
        try
        {
            Console.WriteLine("Validating if value 5 is at the minimum value 5 using IsAtMin: Result = " + ValidationUtils.IsAtMin(5, 5));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsAtMin: " + ex.Message);
        }

        // Test IsAtMin with incorrect type
        try
        {
            Console.WriteLine("Validating if string 'five' is at the minimum value 5 using IsAtMin: " + ValidationUtils.IsAtMin("five", 5));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsAtMin (incorrect type): " + ex.Message);
        }

        // Test IsGreaterThan
        try
        {
            Console.WriteLine("Validating if value 6 is greater than 5 using IsGreaterThan: Result = " + ValidationUtils.IsGreaterThan(6, 5));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsGreaterThan: " + ex.Message);
        }

        // Test IsGreaterThan with incorrect type
        try
        {
            Console.WriteLine("Validating if string 'six' is greater than 5 using IsGreaterThan: " + ValidationUtils.IsGreaterThan("six", 5));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsGreaterThan (incorrect type): " + ex.Message);
        }

        // Test IsLessThan
        try
        {
            Console.WriteLine("Validating if value 4 is less than 5 using IsLessThan: Result = " + ValidationUtils.IsLessThan(4, 5));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsLessThan: " + ex.Message);
        }

        // Test IsLessThan with incorrect type
        try
        {
            Console.WriteLine("Validating if string 'four' is less than 5 using IsLessThan: " + ValidationUtils.IsLessThan("four", 5));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsLessThan (incorrect type): " + ex.Message);
        }

        // Test AllElementsMatch
        try
        {
            List<int> elements = new List<int> { 2, 4, 6 };
            Console.WriteLine("Validating if all elements in the list are even using AllElementsMatch (predicate x % 2 == 0): Result = " + ValidationUtils.AllElementsMatch(elements, new Func<object, bool>(x => (int)x % 2 == 0)));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in AllElementsMatch: " + ex.Message);
        }

        // Test IsAlphabetical
        try
        {
            Console.WriteLine("Validating if string 'Hello' is alphabetical using IsAlphabetical: Result = " + ValidationUtils.IsAlphabetical("Hello"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsAlphabetical: " + ex.Message);
        }

        // Test IsNumeric
        try
        {
            Console.WriteLine("Validating if string '1234' is numeric using IsNumeric: Result = " + ValidationUtils.IsNumeric("1234"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsNumeric: " + ex.Message);
        }

        // Test IsSelectionMade
        try
        {
            Console.WriteLine("Validating if a selection is made in a filled list using IsSelectionMade: Result = " + ValidationUtils.IsSelectionMade(new List<int> { 1, 2, 3 }));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsSelectionMade: " + ex.Message);
        }

        // Test IsLengthAtValue
        try
        {
            Console.WriteLine("Validating if the length of a list is 3 using IsLengthAtValue: Result = " + ValidationUtils.IsLengthAtValue(new List<int> { 1, 2, 3 }, 3));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsLengthAtValue: " + ex.Message);
        }

        // Test IsValidEnumValue
        try
        {
            Console.WriteLine("Validating if DayOfWeek.Monday is a valid value for DayOfWeek enum using IsValidEnumValue: Result = " + ValidationUtils.IsValidEnumValue(DayOfWeek.Monday, typeof(DayOfWeek)));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in IsValidEnumValue: " + ex.Message);
        }

        Console.WriteLine("\nValidationUtils Test Suite Complete.");
    }
}
