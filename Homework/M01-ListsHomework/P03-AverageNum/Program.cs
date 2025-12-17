namespace P03_AverageNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (numbers.Length != 12)
            {
                Console.WriteLine();
            }
            else
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                double average = (double)sum / numbers.Length;
                Console.WriteLine($"{average:F2}");
            }
        }
    }
}