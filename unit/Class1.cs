using System;

namespace Unit
{
    public class Unit
    {
        //public static void Main(string[] args)
        //{
        //    double x, a, b, c;
        //    double F;
        //    Console.WriteLine("Введите x");
        //    x = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Введите a");
        //    a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Введите b");
        //    b = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Введите c");
        //    c = Convert.ToDouble(Console.ReadLine());
        //    //Unit1.unit(x, a, b, c);
        //    Console.WriteLine("F = ");
        //}
        public double calc(double x, double a, double b, double c)
        {
            if ((x< 0) && (b != 0))
            {
               return a* Math.Pow(x, 2) + b;
            }
            else if ((x > 0) && (b == 0))
            {
                return (x - a) / (x - c);
            }
            else
            {
                return x / c;
            }
        }
    }
}
