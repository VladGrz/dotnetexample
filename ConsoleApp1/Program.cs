using System;
namespace ConsoleApp1
{
    public class Program
    {
        static public int Example(int a, int b, int c)
        {
            int V = a * b * c;
            Console.WriteLine(V.ToString());
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);
            Console.WriteLine("Введiть друге число");
            string S2 = Console.ReadLine();
            int b = int.Parse(S2);
            Console.WriteLine("Введiть третє число");
            string S3 = Console.ReadLine();
            int c = int.Parse(S3);
            Example(a, b, c);
            Console.ReadLine();
        }
    }
}