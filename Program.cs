using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Input a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b:");
            double b = double.Parse(Console.ReadLine());
            x = a;
            y = b;
            while(x != y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else y = y + b;
            }
            Console.WriteLine(x);
                


           
        }
    }
}
