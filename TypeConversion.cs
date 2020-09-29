using System;

namespace TypeConversionApplication
{
    public class ReadonApplication
    {
        readonly int ri1 = 10;
        readonly int ri2;
        public void ReadonTest()
        {
            Console.WriteLine("ri1:{0}, ri2:{1}", ri1, ri2);
        }

        public ReadonApplication(int i)
        {
            ri2 = i;
        }
    }
    public class ExplicitConversion
    {
        static void Main1(string[] args)
        {
            double d = 123.89;
            double d1 = 314159E-5;
            float f = 53.005f;
            bool b = true;
            int i, j = (2 == 3) ? 10 : 20;

            i = (int)d; //123
            Console.WriteLine("{0}, {1}", i.ToString(), j.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(false.ToString());
            Console.WriteLine(d1.ToString());
            Console.WriteLine(typeof(ReadonApplication));

            ReadonApplication ra = new ReadonApplication(20);
            Console.WriteLine((ra is ReadonApplication).ToString());
            ra.ReadonTest();

            Console.ReadLine();
        }
    }
}