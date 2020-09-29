using System;

namespace InheritanceApplication
{
    class Shape
    {
        // TODO Test
        protected int width;
        protected int height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }

    public interface PaintCost
    {
        int getCost(int area);
    }

    class Rectangle: Shape, PaintCost
    {
        public int getArea()
        {
            return height * width;
        }
        public int getCost(int area)
        {
            return area *= 70;
        }
    }
    
    public class InheritanceTest
    {
        static void Main1(string[] args)
        {
            Rectangle rect = new Rectangle();
            int area;

            rect.setHeight(5);
            rect.setWidth(7);
            area = rect.getArea();

            Console.WriteLine("Area: {0}", rect.getArea());
            Console.WriteLine("Cost: {0}", rect.getCost(area));
            Console.ReadLine();
        }    
    }
}