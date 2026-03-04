namespace Extension.FactorialMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = -1;
            long result = num.Factorial();

            Console.WriteLine("Factorial of {0} is: {1} ", num, result);
        }
    }
}
