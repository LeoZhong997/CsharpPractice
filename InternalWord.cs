using System;

namespace InternalWordApplication
{
    class Rectangle
    {
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}; Width: {1}; Area: {2}", length, width, GetArea());
        }
    }
    public class InternalWordTest
    {
        static void Main1(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();
            
            r1.length = 4.2;
            r1.width = 3.2;
            r2.length = 5.2;
            r2.width = 4.2;

            r1.Display();
            r2.Display();
            Console.ReadLine();
        }
    }
}