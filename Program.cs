using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To Line Comparison*******");
            double Length1;
            double Length2;
            Random Number = new Random();
            double x1 = Number.Next(0, 3);
            double x2 = Number.Next(0, 3);
            double y1 = Number.Next(0, 3);
            double y2 = Number.Next(0, 3);
            double x3 = Number.Next(0, 3);
            double x4 = Number.Next(0, 3);
            double y3 = Number.Next(0, 3);
            double y4 = Number.Next(0, 3);
            Length1 = (Math.Sqrt((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Length2 = (Math.Sqrt((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3)));
            Console.WriteLine("1st Line Length is : " + Length1);
            Console.WriteLine("2nd Line Length is : " + Length2);

            if (Length1 == Length2)
            {
                Console.WriteLine("Lines are Equal");

            }
            else if (Length1 > Length2)
            {
                Console.WriteLine("Line 1 is Greter Than Line 2");
            }
            else
            {
                Console.WriteLine("Line 2 is Greater Than Line 1");
            }
        }
    }
}