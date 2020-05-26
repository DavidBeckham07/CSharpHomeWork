using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class ShapeFactory
    {
        static Random r = new Random();
        public static void Calculate(IShape shape)
        {
            Console.Out.WriteLine(shape);
        }


        public static void run()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Out.Write(i + ": ");
                switch(r.Next() % 3)
                {
                    case 0:
                        Calculate(new Rectangle(r.Next(1, 10), r.Next(1, 10)));
                        break;
                    case 1:
                        Calculate(new Square(r.Next(1, 10)));
                        break;
                    case 2:
                        Calculate(new Triangle(r.Next(1, 10), r.Next(1, 10)));
                        break;
                }
 
            }
        }
    }
}
