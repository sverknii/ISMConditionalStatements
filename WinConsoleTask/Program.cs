using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y, z, result;
            double numerator1, numerator2, denominator1, denominator2;
            double pow_y;
            string s_result;

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.WriteLine("\tПрактична робота #2, Бiронт Тарас");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("\tВведите X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("\tВведите Y: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("\tВведите Z: ");
            z = double.Parse(Console.ReadLine());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            pow_y = Math.Pow(y, (2 - z));
            numerator1 = 2 * Math.Cos(x * x) - (1.0 / 2.0);
            denominator1 = (1.0 / 2.0) + Math.Sin(pow_y);
            numerator2 = z * z;
            denominator2 = 7 - (z / 3.0);
            result = (numerator1 / denominator1) + (numerator2 / denominator2);
            s_result = result.ToString("0.00");

            Console.WriteLine("\tYour x = {0}, y = {1}, z = {2}", x, y, z);
            Console.WriteLine("\tResult = {0}", s_result);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


        }
    }
}
