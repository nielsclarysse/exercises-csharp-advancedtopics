namespace MyExtensions
{
    public static class IntegerExtensions
    {
        extension(int value) {
            public boolean IsOdd() => value % 2 == 0;
        }
    }
}
