public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 1;

        for (int i = 1; i <= n; i++)
        {
            a = a * i;
        }
        Console.WriteLine(a);
    }
}