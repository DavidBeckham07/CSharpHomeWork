using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Shape
{
    public interface IShape
    {
        double Area { get; }
    }

    public class Triangle : IShape
    {
        public int  Width { get; set; }
        public int Height { get; set; }
        public double Area => Width * Height * 0.5;
        public Triangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public override string ToString()
        {
            return $"Triangle(width:{Width}, height{Height}, area{Area})";
        }
    }

    public class Rectangle: IShape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public double Area => Height * Width;
        public Rectangle(int h, int w)
        {
            Height = h;
            Width = w;
        }
        public override string ToString()
        {
            return $"Rectangle(Height:{Height}, Width:{Width}, Area:{Area})";
        }
    }

    public class Square : Rectangle
    {
        public Square(int width): base(width, width){}
        public override string ToString()
        {
            return $"Square(Width:{Width}, Area:{Area})";
        }

    }
}
