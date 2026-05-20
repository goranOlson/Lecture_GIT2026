namespace GIT2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Sum(a, b);

            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int number in numbers)
            {
                int x = number;
                Console.WriteLine(x);
            }
        }
           
        private static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }






















    }
}
