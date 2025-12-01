public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int LeftSide = 0; int RightSide = 0;

        for (int i = 0; i < n; i++)
        {
            LeftSide += int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            RightSide += int.Parse(Console.ReadLine());
        }
        int diff = Math.Abs(LeftSide - RightSide);
        if (diff != 0)
        {
            Console.WriteLine($"No, diff = {diff}");
        }
        else
        {
            Console.WriteLine($"Yes, sum = {LeftSide}");
        }
    }
}