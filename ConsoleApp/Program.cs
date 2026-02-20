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