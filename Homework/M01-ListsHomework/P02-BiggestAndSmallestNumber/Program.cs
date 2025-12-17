namespace P02_BiggestAndSmallestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (numbers.Length != 8)
            {
                Console.WriteLine();
            }
            else
            {
                int biggest = numbers[0];
                int smallest = numbers[0];
                foreach (int number in numbers)
                {
                    if (number > biggest)
                    {
                        biggest = number;
                    }
                    else if (number < smallest)
                    {
                        smallest = number;
                    }
                }
                Console.WriteLine($"The biggest number is: {biggest}");
                Console.WriteLine($"The smallest number is: {smallest}");
            }
        }
    }
}