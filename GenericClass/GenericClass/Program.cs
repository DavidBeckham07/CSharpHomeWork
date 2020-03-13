using System;

namespace GenericClass
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> intList = new List<int>(10);
            Random r = new Random();
            for (int i = 1; i < 10; i++)
            {
                intList.add(r.Next(0,100)) ;
                //Console.WriteLine($"No{i}：");
            }

            intList.ForEach((int x) => Console.WriteLine($"{x}"));

            int sum = 0,max = int.MinValue, min = int.MaxValue;

            intList.ForEach(x => sum += x);
            intList.ForEach(x => { if (max < x) { max = x; } }) ;
            intList.ForEach(x => { if (min > x) { min = x; } });
            Console.WriteLine($"sum:{sum} max:{max} min:{min}");


        }
    }
}
