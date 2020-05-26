using System;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string result = "";
            Console.WriteLine("input a positive number");
            if(int.TryParse(Console.ReadLine(), out int input))
            {
                if(input < 0)
                {
                    Console.WriteLine("it is not a positive number");
                }
                int prime = 2;
                while(input != 1)
                {
                    if(input % prime == 0)
                    {
                        input /= prime;
                        Console.Write(prime.ToString() + " ");
                    }
                    else
                    {
                        prime++;
                    }

                }        
            }
            else
            {
                Console.WriteLine("input error");
            }





        }
    }
}
