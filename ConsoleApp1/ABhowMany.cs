using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ABhowMany :IGame
    {

        int[] randomNum = new int[4];
        int[] AnsNum = new int[4];
        public void Setup()
        {
            try
            {             
                for (int i = 0; i < 4; i++) //隨機產生4個不重複的數字(0~9)
                {
                    if (i == 0)
                    {
                        randomNum[i] = new Random().Next(10);
                    }
                    else
                    {
                        int j = i - 1;
                        randomNum[i] = new Random().Next(10);
                        while (j >= 0)
                        {
                            while (randomNum[i] == randomNum[j])
                            {
                                randomNum[i] = new Random().Next(10);
                                j = i - 1;
                            }
                            j = j - 1;
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine($"{exp.ToString()}");
                throw;
            }
            
        }
        
        public void Play()        
        {
            
            int inputNum = 0;
            int A = 0;            
            try
            {
                while (true)    //測試輸入是否正常
                {
                    Console.WriteLine("請輸入四個數字不重複");
                    inputNum = CheakNum();//檢測否為4位數 數字
                    if (inputNum == 0) { continue; }                    
                    inputNum = CheakRepeat(inputNum);//檢測有沒有重複
                    if (inputNum == 0) { continue; }
                    A = CheakAns();//幾A幾B

                    if (A == 4) //獲勝
                    {
                        break;
                    }
                }    
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
        }
        public int CheakNum()   //檢測否為4位數 數字
        {
            int inputNum; //轉換為輸入的數字用
            string inputStr = Console.ReadLine();   //接收使用者輸入的字
            if(inputStr.Length !=4)
            {
                return 0;
            }            
            if (Int32.TryParse(inputStr, out inputNum)) //轉換為輸入的數字 & 檢查是否為數字
            {
                return inputNum;
            }
            else
            {                
                return 0;
            }
        }
        public int CheakRepeat(int inputNum)   //檢測有沒有重複
        {

            AnsNum[0] = inputNum / 1000;
            AnsNum[1] = inputNum / 100 % 10;
            AnsNum[2] = inputNum / 10 % 10;
            AnsNum[3] = inputNum % 10;
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (AnsNum[i] == AnsNum[j])
                    {
                        Console.WriteLine($"第{i + 1}和第{j + 1}個重複了");
                        return 0;
                    }
                }
            }
            return inputNum;
        }
        public int CheakAns() //幾A幾B
        {
            int A = 0;
            int B = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (AnsNum[j] == randomNum[i])
                    {
                        if (i == j)
                        {
                            A++;
                        }
                        else
                        {
                            B++;
                        }
                    }

                }
            }
            Console.WriteLine($"{A}A{B}B");
            return A;
        }


    }

}
