using System;

namespace Linecomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int y1;
            int x2;
            int y2;
            Console.WriteLine("Enter x1");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
        }
        
    }
}
