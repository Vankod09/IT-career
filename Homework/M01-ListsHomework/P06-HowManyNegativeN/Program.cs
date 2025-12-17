namespace P06_HowManyNegativeN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int negativeCount = 0;

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    negativeCount++;
                }
            }
            Console.WriteLine(negativeCount);
        }
    }
}