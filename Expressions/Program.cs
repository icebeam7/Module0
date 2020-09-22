using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = 20.56;
            double F, K, R;

            Console.WriteLine("Temperature conversions");
            Console.WriteLine(C + " degrees Celsius");

            F = 1.8 * C + 32;
            Console.WriteLine(F + " degrees Fahrenheit");

            K = 273.15 + C;
            Console.WriteLine(K + " degrees Kelvin");

            // 9/5 is a division between integers, so it returns an integer (1)
            // you must use a double value to get the real value (1.8)
            R = 9.0 / 5 * (C + 273.15);
            Console.WriteLine(R + " degrees Rankine");

            /////////// Operators precedence
            double x = 19, y = -6, z = 7, w = 8;

            double n = ((x * y) / (x + z)) - ((3 * z + y - x) / y);
            Console.WriteLine(n); // -5.05

            ////////// Boolean expressions
            bool a, b, c, d, e, f;
            a = x > y;
            Console.WriteLine(a);

            b = w < z;
            Console.WriteLine(b);

            c = (x > y) && (w < z);
            Console.WriteLine(c);

            d = (x > y) || (w < z);
            Console.WriteLine(d);

            e = !(x > y);
            Console.WriteLine(e);

            f = x + 3 == 22;
            Console.WriteLine(f);
        }
    }
}
