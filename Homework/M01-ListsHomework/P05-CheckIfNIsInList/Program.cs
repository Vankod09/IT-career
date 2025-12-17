namespace P05_CheckIfNIsInList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int n = int.Parse(Console.ReadLine()!);

            if (numbers.Contains(n))
            {
                Console.WriteLine($"The number {n} is in the list.");
            }
            else
            {
                Console.WriteLine($"The number {n} is not in the list.");
            }
        }
    }
}