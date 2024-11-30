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
        Console.WriteLine("Validating if value 5 is greater than 3 using ValidateWithPredicate: Result = " + ValidationUtils.ValidateWithPredicate(5, new Func<object, bool>(x => (int)x > 3)));

        // Test ValidateWithPredicate with incorrect type
        Console.WriteLine("Validating if value 5 with incorrect type (string instead of Func) using ValidateWithPredicate: Result = " + ValidationUtils.ValidateWithPredicate(5, "not a function"));

        // Test IsNull
        Console.WriteLine("Validating if value null is null using IsNull: Result = " + ValidationUtils.IsNull(null));
        Console.WriteLine("Validating if value 5 is null using IsNull: Result = " + ValidationUtils.IsNull(5));

        // Test IsDefault
        Console.WriteLine("Validating if integer value 5 is default using IsDefault: Result = " + ValidationUtils.IsDefault(5));
        Console.WriteLine("Validating if integer value 0 is default using IsDefault: Result = " + ValidationUtils.IsDefault(0));

        // Test IsCollectionEmpty
        List<int> emptyList = new List<int>();
        Console.WriteLine("Validating if an empty list [] is empty using IsCollectionEmpty: Result = " + ValidationUtils.IsCollectionEmpty(emptyList));
        List<int> filledList = new List<int> { 1, 2, 3 };
        Console.WriteLine("Validating if a filled list [1, 2, 3] is empty using IsCollectionEmpty: Result = " + ValidationUtils.IsCollectionEmpty(filledList));

        // Test IsCollectionEmpty with incorrect type
        Console.WriteLine("Validating if value 5 is a collection using IsCollectionEmpty: Result = " + ValidationUtils.IsCollectionEmpty(5));

        // Test IsEnumerableEmpty
        IEnumerable emptyEnumerable = new List<int>();
        Console.WriteLine("Validating if an empty enumerable [] is empty using IsEnumerableEmpty: Result = " + ValidationUtils.IsEnumerableEmpty(emptyEnumerable));
        IEnumerable filledEnumerable = new List<int> { 1, 2, 3 };
        Console.WriteLine("Validating if a filled enumerable [1, 2, 3] is empty using IsEnumerableEmpty: Result = " + ValidationUtils.IsEnumerableEmpty(filledEnumerable));

        // Test IsEnumerableEmpty with incorrect type
        Console.WriteLine("Validating if a string value 'Not an enumerable' is an enumerable using IsEnumerableEmpty: Result = " + ValidationUtils.IsEnumerableEmpty("Not an enumerable"));

        // Test IsEmpty
        Console.WriteLine("Validating if an empty list [] is empty using IsEmpty: Result = " + ValidationUtils.IsEmpty(new List<int>()));

        // Test IsEmpty with incorrect type
        Console.WriteLine("Validating if integer value 10 is empty using IsEmpty: Result = " + ValidationUtils.IsEmpty(10));

        // Test MatchesPattern
        Console.WriteLine("Validating if string 'Hello123' matches the pattern '\\d+' using MatchesPattern: Result = " + ValidationUtils.MatchesPattern("Hello123", "\\d+"));

        // Test MatchesPattern with incorrect type
        Console.WriteLine("Validating if integer value 123 matches the pattern '\\d+' using MatchesPattern: Result = " + ValidationUtils.MatchesPattern(123, "\\d+"));

        // Test IsUnique
        List<int> numbers = new List<int> { 1, 2, 3 };
        Console.WriteLine("Validating if value 4 is unique in the list [1, 2, 3] using IsUnique: Result = " + ValidationUtils.IsUnique(4, numbers));

        // Test IsUnique with incorrect type
        Console.WriteLine("Validating if value 'four' is unique in the list [1, 2, 3] using IsUnique: Result = " + ValidationUtils.IsUnique("four", new List<int> { 1, 2, 3 }));

        // Test IsAtMin
        Console.WriteLine("Validating if value 5 is at the minimum value 5 using IsAtMin: Result = " + ValidationUtils.IsAtMin(5, 5));
        Console.WriteLine("Validating if value 'five' is at the minimum value 5 using IsAtMin (expected to handle error internally): Result = " + ValidationUtils.IsAtMin("five", 5));

        // Test IsGreaterThan
        Console.WriteLine("Validating if value 6 is greater than 5 using IsGreaterThan: Result = " + ValidationUtils.IsGreaterThan(6, 5));
        Console.WriteLine("Validating if value 'six' is greater than 5 using IsGreaterThan (expected to handle error internally): Result = " + ValidationUtils.IsGreaterThan("six", 5));

        // Test IsLessThan
        Console.WriteLine("Validating if value 4 is less than 5 using IsLessThan: Result = " + ValidationUtils.IsLessThan(4, 5));
        Console.WriteLine("Validating if value 'four' is less than 5 using IsLessThan (expected to handle error internally): Result = " + ValidationUtils.IsLessThan("four", 5));

        // Test AllElementsMatch
        List<int> elements = new List<int> { 2, 4, 6 };
        Console.WriteLine("Validating if all elements in the list [2, 4, 6] are even using AllElementsMatch (predicate x % 2 == 0): Result = " + ValidationUtils.AllElementsMatch(elements, new Func<object, bool>(x => (int)x % 2 == 0)));

        Console.WriteLine("\nValidationUtils Test Suite Complete.");
    }
}
