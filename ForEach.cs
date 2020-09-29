using System;

namespace ForEachApplication
{
    public class ForEachTest
    {
        static void Main1(string[] args)
        {
            int[] fibarray = new int[] {0, 1, 2, 4, 3, 2, 1};
            foreach(int i in fibarray)
            {
                Console.WriteLine(i);
            } 
            Console.WriteLine();

            // 类似于 foreach 循环
            for(int i = 0; i < fibarray.Length; i++)
            {
                Console.WriteLine(fibarray[i]);
            }
            Console.WriteLine();

            int count = 0;  // 设置集合中元素的计数器
            foreach(int i in fibarray)
            {
                count += 1;
                Console.WriteLine("Element #{0}: {1}", count, i);
            }
            Console.WriteLine("Number of elements in the array: {0}", count);
        }
    }
}