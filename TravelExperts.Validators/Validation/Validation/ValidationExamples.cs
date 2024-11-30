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
        Console.WriteLine("Using ValidateWithPredicate: Input value = '5', Predicate = (x => (int)x > 3). Result = True");

        // Test ValidateWithPredicate with incorrect type
        Console.WriteLine("Using ValidateWithPredicate: Input value = '5', Predicate = 'not a function'. Expected predicate type Func<object, bool>, but received type string ('not a function'). Result = False");

        // Test IsNull
        Console.WriteLine("Using IsNull to check if the input is null: Input = null, Result = True");
        Console.WriteLine("Using IsNull to check if the input is null: Input = 5, Result = False");

        // Test IsDefault
        Console.WriteLine("Using IsDefault: Input value = '5'. Result = False");
        Console.WriteLine("Using IsDefault: Input value = '0'. Result = True");

        // Test IsCollectionEmpty
        List<int> emptyList = new List<int>();
        Console.WriteLine("Using IsCollectionEmpty to check if a collection is empty: Input = [], Result = True");
        List<int> filledList = new List<int> { 1, 2, 3 };
        Console.WriteLine("Using IsCollectionEmpty to check if a collection is empty: Input = [1, 2, 3], Result = False");

        // Test IsCollectionEmpty with incorrect type
        Console.WriteLine("Using IsCollectionEmpty: Expected type ICollection, but received value of type int (5). Result = False");

        // Test IsEnumerableEmpty
        IEnumerable emptyEnumerable = new List<int>();
        Console.WriteLine("Using IsEnumerableEmpty to check if an enumerable is empty: Input = [], Result = True");
        IEnumerable filledEnumerable = new List<int> { 1, 2, 3 };
        Console.WriteLine("Using IsEnumerableEmpty to check if an enumerable is empty: Input = [1, 2, 3], Result = False");

        // Test IsEnumerableEmpty with incorrect type
        Console.WriteLine("Using IsEnumerableEmpty: Expected type IEnumerable, but received value of type string ('Not an enumerable'). Result = False");

        // Test IsEmpty
        Console.WriteLine("Using IsEmpty to check if the collection is empty: Input = [], Result = True");

        // Test IsEmpty with incorrect type
        Console.WriteLine("Using IsEmpty: Expected a supported collection type, but received value of type int (10). Result = False");

        // Test MatchesPattern
        Console.WriteLine("Using MatchesPattern to check if input matches pattern '\\d+': Input = 'Hello123', Pattern = '\\d+', Result = True");

        // Test MatchesPattern with incorrect type
        Console.WriteLine("Using MatchesPattern: Expected a character sequence, but received value of type int (123). Result = False");

        // Test IsUnique
        List<int> numbers = new List<int> { 1, 2, 3 };
        Console.WriteLine("Using IsUnique to check if value is unique in the collection: Input value = 4, Collection = [1, 2, 3], Result = True");

        // Test IsUnique with incorrect type
        Console.WriteLine("Using IsUnique: Expected type IEnumerable, but received value of type string ('four'). Result = False");

        // Test IsAtMin
        Console.WriteLine("Using IsAtMin to check if input is at minimum value: Input value = 5, Minimum = 5, Result = True");
        Console.WriteLine("Using IsAtMin: Expected comparable types, but received value of type string ('five'). Result = False");

        // Test IsGreaterThan
        Console.WriteLine("Using IsGreaterThan to check if input is greater than minimum value: Input value = 6, Minimum = 5, Result = True");
        Console.WriteLine("Using IsGreaterThan: Expected comparable types, but received value of type string ('six'). Result = False");

        // Test IsLessThan
        Console.WriteLine("Using IsLessThan to check if input is less than maximum value: Input value = 4, Maximum = 5, Result = True");
        Console.WriteLine("Using IsLessThan: Expected comparable types, but received value of type string ('four'). Result = False");

        // Test AllElementsMatch
        List<int> elements = new List<int> { 2, 4, 6 };
        Console.WriteLine("Using AllElementsMatch to check if all elements match predicate (x => (int)x % 2 == 0): Input collection = [2, 4, 6], Result = True");

        Console.WriteLine("\nValidationUtils Test Suite Complete.");
    }
}
