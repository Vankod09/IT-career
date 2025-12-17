namespace P01_SumOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length != 10)
            {
                Console.WriteLine();
            }
            else
            {
                int sum = numbers.Sum();
                Console.WriteLine(sum);
            }
        }
    }
}