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
            }


            for (int i = 0; i < (int)GameMgr.Bonder; i++) //畫圖
            {
                for (int j = 0; j < (int)GameMgr.Bonder; j++)
                {
                    Console.Write($"{array[i, j]}");
                }
                Console.WriteLine("");
            }
        }


    }
}
