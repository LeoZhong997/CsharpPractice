using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JieCheng
{
    public class JieChengApplication
    {
        public int Jc(int num)
        {
            return num > 0 ? num * Jc(num - 1) : 1;
        }
    }

    public class JieChengExcution
    {
        static void Main1(string[] args)
        {
            JieChengApplication jca = new JieChengApplication();
            int result = jca.Jc(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("result is {0}", result);
            Console.ReadKey();
        }
    }
}