using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConstructs
{
    public class WhileLoops
    {
        public const int NUM_OF_COINS_FLIP = 20;
        public void FlipCoin20times()
        {
            int i = 0;
            while( i < NUM_OF_COINS_FLIP) 
            {
                i++;
                Random random = new Random();
                int coin = random.Next(0, 2);

                switch( coin )
                {
                    case 0:
                        Console.WriteLine("Its Heads.");
                        break;
                    case 1:
                        Console.WriteLine("Its Tails.");
                        break;
                    default:
                        Console.WriteLine("Its in the air.");
                        break;
                }
            }
            Console.WriteLine("Total Number of times coin flips :" + i);
        }

        public void ReverseWord()
        {
            Console.WriteLine("Enter the word you want to reverse!!!");

            string word = Console.ReadLine();

            int stringLength = word.Length - 1;

            string reverseString = "";

            while ( stringLength >= 0 )
            {
                reverseString = reverseString + word[stringLength];
                stringLength--;
            }

            Console.WriteLine("\n" + reverseString);
        }

        public void SumOfNaturalNumbers()
        {
            int i = 1;
            int sum = 0;

            while(i <= 5)
            {
                Console.WriteLine(i);
                sum = sum + i;
                i++;
            }
            Console.WriteLine("Sum of first 5 natural numbers is: " + sum);
        }
    }
}
