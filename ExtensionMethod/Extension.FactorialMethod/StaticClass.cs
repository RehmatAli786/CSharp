namespace Extension.FactorialMethod
{
    internal static class StaticClass
    {
        public static long Factorial(this int i)
        {
            if (i >= 0 && i <= 2)
                return i;
            return i * Factorial(i - 1);
        }
    }
}
