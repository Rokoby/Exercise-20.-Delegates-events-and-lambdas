using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20.Делегаты__события_и_лямбды
{
    internal class Program
    {
        delegate double Delegate (double x);
        static void Main(string[] args)
        {
            Delegate Delegate = Length;
            Delegate += Square;
            Delegate += Volume;
            Console.WriteLine("Введите R");
            double r = Convert.ToDouble(Console.ReadLine());
            Delegate(r);
            Console.ReadKey();
        }
        static double Length(double r)
        {
            double d = 2 * r * Math.PI;
            Console.WriteLine(d);
            return d;
        }
        static double Square(double r)
        {
            double s = Math.PI * Math.Pow(r,2);
            Console.WriteLine(s);
            return s;
        }
        static double Volume(double r)
        {
            double v = 4.0/3 * Math.PI * Math.Pow(r,3);
            Console.WriteLine(v);
            return v;
        }
    }
}
