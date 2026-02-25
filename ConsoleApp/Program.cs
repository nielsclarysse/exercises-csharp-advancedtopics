using MyExtensions;

// ***********
// * EX1 - A *
// ***********

/*IEnumerable<int> Fibonacci(int length)
{
    (int a, int b) = (0, 1);

    for (int i = 0; i < length; i++)
    {
        yield return a;

        (a, b) = (b, a + b);
    }
}

foreach (int i in Fibonacci(10))
{
    Console.WriteLine(i);
}*/

// ***********
// * EX1 - B *
// ***********

/*static void Main()
{
    Console.WriteLine("Please enter a text: ");
    string myText = Console.ReadLine().Trim().ToLower();

    string myReversedText = string.Concat(Reverse(myText));

    Console.WriteLine($"The text \"{myText}\" is {(myText == myReversedText ? "a" : "not a")} palindrome");
}

static IEnumerable<char> Reverse(string text)
{
    for (int i = text.Length - 1; i >= 0; i--)
    {
        yield return text[i];
    }
}

Main();*/

// ***********
// * EX1 - C *
// ***********

/*FactorialResult factorialResult = Calculate(10);
Console.WriteLine(factorialResult.Value);

static FactorialResult Calculate(int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return new FactorialResult(n, result);
}

public record FactorialResult(int Number, long Value);*/

// *******
// * EX2 *
// *******

/*// Zonder classes of records.
// Dit omdat het iets simpeler maakt om de switch expression te demonstreren.
var groups = new[]
{
    new { GroupName = "1TI", Teacher = new { Name = "Alice" }, Students = new[] { "Student1", "Student2" } },
    new { GroupName = "2TI", Teacher = new { Name = "Bob" }, Students = new[] { "Student1", "Student2", "Student3" } },
    new { GroupName = "3TI", Teacher = new { Name = "Charlie" }, Students = Array.Empty<string>() }
};

foreach (var group in groups)
{
    var message = group switch
    {
        { Teacher: { Name: string name } } when name.StartsWith("P") => $"Group name: {group.GroupName}",
        { GroupName: "2TI", Students.Length: > 2 } => $"Group: {group.GroupName}, Teacher: {group.Teacher.Name}",
        { Students.Length: > 0 } => $"Group: {group.GroupName}, Student Count: {group.Students.Length}",
        _ => "No matching criteria met."
    };

    Console.WriteLine(message);
}*/

// EX3-4 will be kept as preperation for the exam.

// ***********
// * EX5 - B *
// ***********

/*int number = 5;
Console.WriteLine(number.IsOdd());

namespace MyExtensions
{
    public static class IntegerExtensions
    {
        extension(int value)
        {
            public bool IsOdd() => value % 2 == 0;
        }
    }
}*/

// ***********
// * EX5 - C *
// ***********

string text = "Hello World!";
Console.WriteLine(text.CountChar());

namespace MyExtensions
{
    public static class StringExtensions
    {
        extension(string text)
        {
            public int CountChar() => text.Trim().Count();
        }
    }
}