using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_with_10_Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make an array of 10 ints and fill it with random numbers
            // Find which one is largest (fill in any way you like)
            // Fill it with:
            // Random rnd = new Random();
            // int number = rnd.Next (0, 10);
            // this will put a random number from 0 - 9 into number

            Random rnd = new Random();

            int[] gameNum = new int[10];
            int storeMax = 0;

            for (int i = 0; i <= 9; i++)
            {
                gameNum[i] = rnd.Next(0, 10);
                Console.WriteLine(gameNum[i]);
            }

                if (gameNum[i] > storeMax)              
                {
                    storeMax = gameNum[i];            
                }
                Console.WriteLine("The maximum number is " + storeMax + ".");
            }
            Console.ReadLine();
        }
    }
}
