using System;

namespace PolymorphismApplication
{
    public class TestData
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public class PolymorphismTest
    {
        static void Main1(string[] args)
        {
            TestData dataClass = new TestData();
            int add1 = dataClass.Add(1, 2);
            int add2 = dataClass.Add(1, 2, 3);

            Console.WriteLine("add1: {0}; add2: {1}", add1, add2);
        }
    }
    abstract class Shape
    {
        abstract public int area();
    }
    class Rectangle : Shape
    {
        private int length;
        private int width;
        public Rectangle(int l = 0, int w = 0)
        {
            length = l;
            width = w;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle's area");
            return length * width;
        }
    }
    class RectangleTester
    {
        static void Main1(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            double area = r.area();

            Console.WriteLine("Area: {0}", area);
            Console.ReadLine();
        }
    }
    
    class Shape_ 
    {
        protected int width, height;
        public Shape_(int h = 0, int w = 0)
        {
            width = w;
            height = h;
        }
        public virtual int area()
        {
            Console.WriteLine("Basic Area");
            return 0;
        }
    }
    class Rectangle_ : Shape_
    {
        public Rectangle_(int h = 0, int w = 0) : base(h, w)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle's area: {0}", width * height);
            return width * height;
        }
    }
    class Triangle : Shape_
    {
        public Triangle(int h = 0, int w = 0) : base(h, w)
        {

        }
        public override int area()
        {
            int area = height * width / 2;
            Console.WriteLine("Triangle's area: {0}", area);
            return area;
        }
    }
    class Caller
    {
        public void CallArea(Shape_ sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle_ r = new Rectangle_(10, 7);
            Triangle t = new Triangle(10, 7);
            c.CallArea(r);
            c.CallArea(t);

            Console.ReadLine();

        }
    }
}