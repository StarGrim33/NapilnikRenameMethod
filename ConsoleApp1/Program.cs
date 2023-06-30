namespace ConsoleApp1
{
    internal class Program
    {
        public static int ClampNumbers(int a, int b, int c)
        {
            if (a < b)
                return b;
            else if (a > c)
                return c;
            else
                return a;
        }
    }
}