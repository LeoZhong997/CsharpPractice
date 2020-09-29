using System;

namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.1;
            width = 3.0;
        }    
        public double GetArea()
        {
            /// <summary>
            /// Test comments
            /// <summary>
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}, Width: {1}", length, width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main1(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.GetArea();
            r.Display();
            Console.ReadLine();
        }
    }
}