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
            double length1;
            double length2;
            int m1 = 4;
            int n1 = 3;
            int m2 = 6;
            int n2 = 5;
            length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            length2 = Math.Sqrt((m2 - m1) * (m2 - m1) + (n2 - n1) * (n2 - n1));
            Console.WriteLine(length1);
            Console.WriteLine(length2);
            Console.WriteLine(length1.ToString().Equals(length2.ToString()));
            //lenght.ToString() is a object to string method and .Equals is used for checking their equality
        }
        
    }
}
