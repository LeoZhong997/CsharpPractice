using System;

namespace ArrayApplication
{
    public class ArrayTest
    {
        double getAverage(int[] arr, int size)
        {
            int k;
            double avg;
            int sum = 0;

            for (k = 0; k < size; k++)
            {
                sum += arr[k];
            }

            avg = (double)sum / size;
            return avg;
        }

        class ParamArray
        {
            public int AddElements(params int[] arr)
            {
                int sum = 0;
                foreach(int i in arr)
                {
                    sum += i;
                }
                return sum;
            }

            public void ShowArray(int[] arr)
            {
                foreach(int i in arr)
                {
                    Console.Write("{0}, ", i);
                }
                Console.WriteLine();
            }
        }
        static void Main1(string[] args)
        {
            int[,] a = new int[5,2]{{0,0}, {1,2}, {2,4}, {3,6}, {4,8}};

            int [][] b = new int[][]{new int[]{0,0}, new int[]{1,2,3,5}, 
                new int[]{2,4}, new int[]{3,6}, new int[]{4,8}};
                
            ArrayTest at = new ArrayTest();
            int[] balance = new int[]{1000,2,3,17,50};
            double avg = at.getAverage(balance, balance.Length);
            Console.WriteLine("Array balance's average: {0}", avg);

            ParamArray pa = new ParamArray();
            int[] c = new int[]{512, 720, 250, 567, 889};
            int sum = pa.AddElements(c);
            Console.WriteLine("The sum is {0}", sum);
            
            Console.WriteLine("Before, c: ");
            pa.ShowArray(c);
            
            Array.Reverse(c);
            Console.WriteLine("Reverse after, c: ");
            pa.ShowArray(c);

            Array.Sort(c);
            Console.WriteLine("Sort after, c: ");
            pa.ShowArray(c);


            int i, j;

            for(i=0; i<5; i++)
            {
                for(j=0; j<2; j++)
                {
                    Console.WriteLine("a[{0}, {1}]: {2};", i, j, a[i, j]);
                }
            }

            Console.WriteLine("Length of b: {0}", b.Length);
            for(i=0; i<b.Length; i++)
            {
                Console.WriteLine("Length of b[{0}]: {1}", i, b[i].Length);
                for(j=0; j<b[i].Length; j++)
                {
                    Console.WriteLine("b[{0}][{1}] = {2}", i, j, b[i][j]);
                }
            }

            Console.ReadLine();
        }
    }
}