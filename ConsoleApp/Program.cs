// ***********
// * EX1 - A *
// ***********

IEnumerable<int> Fibonacci(int length)
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
    //Console.WriteLine(i);
}

// ***********
// * EX1 - B *
// ***********

static void Main()
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

//Main();