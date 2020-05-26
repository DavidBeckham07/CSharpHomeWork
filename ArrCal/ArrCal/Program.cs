using System;

namespace ArrCal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            float total = 0;
            float min = float.MaxValue;
            float max = float.MinValue;
            Console.WriteLine("input numbers, separated by a comma");

            string[] inputs = Console.ReadLine().Split("[, ，]");
            try
            {
                for(int i = 0; i < inputs.Length; i++)
                    {
                    float current = (float.Parse(inputs[i]));
                    total += current;
                    max = (current > max ? current : max);
                    min = (current < min ? current : min);
                    }

                Console.WriteLine(
                    "Total:" + total + "\n"
                    + "average:" + total / inputs.Length + "\n"
                    + "min:" + min + "\n"
                    + "max:" + max);

            }
            catch(Exception e)
            {
                Console.WriteLine("input error:" + e.Message);
            }


        }
    }
}
