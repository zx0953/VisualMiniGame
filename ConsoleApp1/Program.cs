using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IGame Game = new ABhowMany();
            Game.Setup();
            Game.Play();            
            
            GreedySnake greedySnake = new GreedySnake();
            greedySnake.init();
            Console.ReadKey();
            */
            //5秒后开始运行，接着每隔1秒的调用Tick方法
            Timer tmr = new Timer(Tick, "tick...", 1000, 500);
            Console.ReadLine();
            tmr.Dispose();
        }
        static void Tick(object data)
        {
            Console.WriteLine(data);
        }
    }
}
