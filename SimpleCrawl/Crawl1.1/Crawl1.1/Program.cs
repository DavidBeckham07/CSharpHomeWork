using System;

namespace Crawl1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SimpleCrawl sc = new SimpleCrawl("http://www.cnblogs.com/dstang2000/");
            sc.relativeCraw();
        }
    }
}
