using System;

namespace CalculatorApplication
{
    public class NullablesAtShow
    {
        static void Main1(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14159;

            double num5 = num3 ?? 5.34;

            bool? boolval = new bool?();

            Console.WriteLine("Show Nullable Val: {0}, {1}, {2}, {3}, {4}", 
                num1, num2, num3, num4, num5);
            Console.WriteLine("Show Nullable BoolVal: {0}", boolval);
            Console.ReadLine();

        }
    }
}