using System;

namespace BaseClassApplication
{
    class Triangle
    {
        
    }
    class Rectangle
    {
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}, Width: {1}, Area: {2}", length, width, GetArea());
        }
    }

    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double l, double w) : base(l, w)
        { }
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        new public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }
    public class BaseClassTest
    {
        static void Main1(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
            Console.ReadLine();
        }
    }
}