using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManjuCoinsPuzzle
{
    class Program
    {
        /// <summary>
        /// If n is divisable by 10 then you may give back 9 coins
        /// If n is even then you may give back exactly n/2-1 coins
        /// if n is divisable by 3 then you may give back 7 coins
        /// If n is divisable by 4 then you may give back 6 coins
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool runMulTimes = true;
            while (runMulTimes)
            {
                Console.WriteLine("Enter the integer");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Coins(num));
                Console.WriteLine("Do you want to continue? Press Y for yes and N for No");
                runMulTimes = Console.ReadLine() == "Y" ? true : false;                
            }
        }

        public static bool Coins(int num)
        {
            bool op = false;

            while(num > 13)
            {
                if(num == 14 || num == 15 || num == 20)
                {
                    return true;
                }
                int tmp10 = 0;
                int tmp2 = 0;
                int tmp3 = 0;
                int tmp4 = 0;

                if(num % 10 == 0)
                {
                    tmp10 = num - 9;
                    if (IsDivisible(tmp10))
                    {
                        num = tmp10;
                        continue;
                    }
                }
                if(num % 2 == 0)
                {
                    tmp2 = num - ((num / 2) - 1);
                    if (IsDivisible(tmp2))
                    {
                        num = tmp2;
                        continue;
                    }
                }
                if (num % 3 == 0)
                {
                    tmp3 = num - 7;
                    if (IsDivisible(tmp3))
                    {
                        num = tmp3;
                        continue;
                    }
                }
                if (num % 4 == 0)
                {
                    tmp4 = num - 6;
                    if (IsDivisible(tmp4))
                    {
                        num = tmp4;
                        continue;
                    }
                }
                return false;
            }
            


            return op;
        }

        public static bool IsDivisible(int num)
        {
           
            if(num % 2 ==0 || num % 3 == 0 || num % 4 == 0 || num % 10 == 0)
            {
                return true;
            }
            return false;
        }      
    }
}
