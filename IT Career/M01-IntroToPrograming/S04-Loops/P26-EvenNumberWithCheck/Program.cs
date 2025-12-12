public class Program
{
    public static void Main()
    {
        for (; ; )
        {

            Console.Write("Enter even number: ");
            string a = Console.ReadLine();
            int n;

            if (!int.TryParse(a, out n))
            {
                Console.WriteLine("Invalid number!");
                continue;
            }
            if (n % 2 != 0)
            {
                Console.WriteLine("The number is not even.");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine($"{n}");
                break;
            }
        }
    }
}