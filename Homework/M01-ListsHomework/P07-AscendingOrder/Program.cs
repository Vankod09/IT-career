namespace P07_AscendingOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Array.Sort(numbers);
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}