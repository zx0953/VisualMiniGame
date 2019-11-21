using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GreedySnake
    {
        enum GameMgr
        {
            Bonder = 40
        };

        char[,] array = new char[(int)GameMgr.Bonder, (int)GameMgr.Bonder];
        public void init()
        {
            bool _change = false;
            for (int i = 0; i < (int)GameMgr.Bonder; i++)
            {
                for (int j = 0; j < (int)GameMgr.Bonder; j++)
                {
                    if (i == 0 || i == (int)GameMgr.Bonder-1)
                    {
                        array[i, j] = '＊';
                    }
                    else if (j == 0 || j == (int)GameMgr.Bonder-1)
                    {
                        array[i, j] = '＊';
                    }
                    else
                    {
                        array[i, j] = '　';
                    }
                }
            }   //初始 設定牆壁
            Draw();
            
        }
        void Timer()
        {
            System.Timers.Timer t = new System.Timers.Timer(500);//實例化Timer類，設置間隔時間為10000毫秒；

            //t.Elapsed += new System.Timers.ElapsedEventHandler(Draw);//到達時間的時候執行事件；

            t.AutoReset = true;//設置是執行一次（false）還是一直執行(true)；

            t.Enabled = true;//是否執行System.Timers.Timer.Elapsed事件；


        }
        void Draw(/*object source, System.Timers.ElapsedEventArgs e*/)
        {
            Console.Clear();
            for (int i = 0; i < (int)GameMgr.Bonder; i++) //畫圖
            {
                for (int j = 0; j < (int)GameMgr.Bonder; j++)
                {
                    Console.Write($"{array[i, j]}");
                }
                Console.WriteLine("");
            }
            Console.SetCursorPosition(0, 0);
            Console.SetWindowSize(Console.WindowWidth, Console.LargestWindowHeight);
        }


    }
}
