using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            */
            GreedySnake greedySnake = new GreedySnake();
            greedySnake.init();
            Console.ReadKey();
        }
    }
}
