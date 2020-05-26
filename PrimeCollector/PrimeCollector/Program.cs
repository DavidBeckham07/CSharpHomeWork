using System;

namespace PrimeCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            bool[] flags = new bool[n + 1];

            for(int i = 0; i < flags.Length; i++)
            {
                flags[i] = true;
            }
            
            for(int i = 2; i * i <= n; i++)
            {
                for(int k = i; k * i <= n;  k++)
                {
                    if(flags[i * k])
                    {
                        flags[i * k] = false;
                    }
                    
                }
                
            }


            for(int i = 2; i< flags.Length; i++)
            {
                if (flags[i])
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
