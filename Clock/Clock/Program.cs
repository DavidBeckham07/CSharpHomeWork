using System;

namespace Clock
{
    class Program
    {
        //private static ClockHandler Tick;

        static void Main(string[] args)
        {

            
            Clock clock = new Clock(0, 5); // 0:05响铃
            clock.Run += Tick;
            clock.Run += Ring;
            clock.Start();
        }




        // 每秒Tick一次
        private static void Tick(object sender, ClockEventArgs cArgs)
        {
            cArgs.SecNum++;
            if (cArgs.SecNum == 60)
            {
                cArgs.SecNum = 0;
                cArgs.MinNum++;
                if (cArgs.MinNum == 60)
                {
                    cArgs.MinNum = 0;
                    cArgs.HourNum = (cArgs.HourNum + 1) % 24;
                }
            }

            Console.WriteLine($"[{cArgs.HourNum}:{cArgs.MinNum}:{cArgs.SecNum}]: TICK");
        }

        //每到闹铃时间Ring一次
        private static void Ring(object sender, ClockEventArgs cArgs)
        {
            if (cArgs.SecNum <= 10
                && cArgs.MinNum == ((Clock)sender).alarmTime.MinNum
                && cArgs.HourNum == ((Clock)sender).alarmTime.HourNum)
            {
                Console.WriteLine($"RING RING RING ...");

            }
        }

    }





    // 声明委托类型，定义事件处理函数
    public delegate void ClockHandler(object sender,ClockEventArgs args);

    public class ClockEventArgs {
        public int SecNum { set; get; }
        public int MinNum { set; get; }
        public int HourNum { set; get; }

    }


    class Clock
    {

        // 创建委托实例
        public event ClockHandler Run;

        // 闹铃时间
        public ClockEventArgs alarmTime;

        //起始时间
        public ClockEventArgs clockArgs;



        public Clock(int h, int m)
        {
            // 设置闹铃时间
            alarmTime = new ClockEventArgs
            {
                HourNum = h,
                MinNum = m
            };

            // 设置闹钟初始时间0：04：50
            clockArgs = new ClockEventArgs();
            clockArgs.HourNum = 0;
            clockArgs.MinNum = 4;
            clockArgs.SecNum = 50;

        }

        public void Start()
        {
            while (true)
            {
                Run(this, clockArgs);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
