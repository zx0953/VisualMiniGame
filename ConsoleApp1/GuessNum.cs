using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 
{
    class GuessNum : IGame
    {
        int guess = -1;
        int RangeMax = -1;
        int intputNum = 0;

        public void Setup()
        {
            try
            {
                Console.WriteLine("請輸入最大範圍");
                while (true)
                {
                    string strRangeMax = Console.ReadLine();
                    if (Int32.TryParse(strRangeMax, out RangeMax))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("輸入數字");
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            
        }

        public void Play()
        {
            try
            {
                guess = new Random().Next(9);
                Console.WriteLine($"0~{RangeMax} 猜一個數字");
                while (true)
                {
                    string inputStr = Console.ReadLine();
                    if (Int32.TryParse(inputStr, out intputNum))
                    {
                        if (intputNum <= RangeMax && intputNum >= 0)
                        {
                            if (guess == intputNum)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("猜錯了");
                            }
                        }
                        else { Console.WriteLine($"0~{RangeMax}啦 艮!!"); }
                    }
                    else
                    {
                        Console.WriteLine($"請輸入數字 0~{RangeMax}");
                        continue;
                    }
                }
                Console.WriteLine("恭喜 恭喜 猜對了");
                Console.ReadKey();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
        }

    }
}
