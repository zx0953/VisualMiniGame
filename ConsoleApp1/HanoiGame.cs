using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    class HanoiGame
    {
        int from = -1;
        int to = -1;
        int temp = -1;
        int disk = -1;
        int aux = -1;
        string[,] array;
        public void Hanoi(int Disk, int Src, int Dest, int Aux)
        {
            if (Disk == 1)
            {
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                Draw(Disk, Src, Dest);
            }
            else
            {
                Hanoi(Disk - 1, Src, Aux, Dest);
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                Draw(Disk, Src, Dest);
                Hanoi(Disk - 1, Aux, Dest, Src);
            }
        }
        public void Setup()
        {
            try
            {
                string input;
                //輸入高度
                while (true)
                {
                    Console.WriteLine("請輸入河內塔的高度：");
                    input = Console.ReadLine();
                    if (Int32.TryParse(input, out disk))
                    {
                        if (disk == 0)
                        {
                            Console.WriteLine("??? 這麼簡單, 還要你幹嘛?");
                        }
                        else if (disk < 0)
                        {
                            Console.WriteLine("??? 還敢負數呀!? 蛤?!");
                        }
                        else
                        {
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("請輸入數字");
                    }
                }
                while (true)
                {
                    Console.WriteLine("起始地的柱子:(1,2,3)");
                    input = Console.ReadLine();
                    if (Int32.TryParse(input, out from))
                    {
                        if (from > 3 || from < 1)
                        {
                            Console.WriteLine("不好意思, 只有三根柱子");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("請輸入數字");
                    }
                }
                while (true)
                {
                    Console.WriteLine("目的地的柱子：(1,2,3)");
                    input = Console.ReadLine();
                    if (Int32.TryParse(input, out to))
                    {
                        if (to > 3 || to < 1)
                        {
                            Console.WriteLine("不好意思, 只有三根柱子");
                        }
                        else if (to == from)
                        {
                            Console.WriteLine($"{from}到{to}???  黑人問號???.JPG");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("請輸入整數數字");
                    }
                }
                #region // 取得 第三柱子
                /* 例如 輸入 1 3  得到  2
                 *      輸入 1 2  得到  3
                 *      輸入 2 3  得到  1
                 */
                aux = 0;
                int[] temp = { 1, 2, 3 };
                foreach (int item in temp)
                {
                    if (item != from && item != to)
                    {
                        aux = item;
                        break;
                    }
                }
                #endregion

                array = new string[3, disk];
                for (int j = 0; j < disk; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == from - 1)
                        {
                            int ints = j + 1;
                            string strs = ints.ToString();
                            strs = Strings.StrConv(strs, VbStrConv.Wide, 0);
                            array[i, j] = strs;
                            
                            Console.Write($"{j + 1}");
                        }
                        else
                        {
                            array[i, j] = "｜";
                            Console.Write("｜");
                        }

                    }
                    Console.WriteLine("");
                }

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }

        //參考演算法: http://notepad.yehyeh.net/Content/DS/CH02/4.php
        //參考演算法: http://program-lover.blogspot.com/2008/06/tower-of-hanoi.html
        public void Play()
        {
            try
            {
                Hanoi(disk, from, to, aux);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }
        public void Draw(int Disk, int Src, int Dest)
        {
            for (int i = disk - 1; i >= 0; i--)
            {
                if (array[Dest - 1, i] == "｜")
                {
                    string s = Disk.ToString();
                    s = Strings.StrConv(s, VbStrConv.Wide, 0);

                    array[Dest - 1, i] = s;
                    break;
                }
            }
            for (int i = disk - 1; i >= 0; i--)
            {
                string s = Disk.ToString();
                s = Strings.StrConv(s, VbStrConv.Wide, 0);
                if (array[Src - 1, i] == s)
                {
                    array[Src - 1, i] = "｜";
                    break;
                }

            }
            for (int j = 0; j < disk; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }


}

/*



            




                   
                */
