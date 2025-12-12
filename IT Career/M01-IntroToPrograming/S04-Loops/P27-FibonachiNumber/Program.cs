class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int f0 = 1;
        int f1 = 1;

        if (n < 2)
        {
            Console.WriteLine(1);
        }
        else
        {
            int fibNum = 0;
            for (int i = 2; i <= n; i++)
            {
                fibNum = f0 + f1;
                f0 = f1;
                f1 = fibNum;
            }
            Console.WriteLine(fibNum);
        }
    }
}