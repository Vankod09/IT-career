namespace P04_InvertedRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (numbers.Length != 15)
            {
                Console.WriteLine();
            }
            else
            {
                Array.Reverse(numbers);
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}