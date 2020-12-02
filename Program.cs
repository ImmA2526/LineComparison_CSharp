using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To Line Comparison*******");
            double Length1;
            Random Number = new Random();
            double x1 = Number.Next(0, 3);
            double x2 = Number.Next(0, 3);
            double y1 = Number.Next(0, 3);
            double y2 = Number.Next(0, 3);
            Length1 = (Math.Sqrt((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("End Points for X1 is : " + x1 + " y1= " + y1);
            Console.WriteLine("End Points for X2 is : " + x2 + " y2= " + y2);
            Console.WriteLine("Length of the Line is :" + Length1);
        }
    }
}