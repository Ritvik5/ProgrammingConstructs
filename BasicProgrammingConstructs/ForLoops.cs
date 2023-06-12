using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConstructs
{
    public class ForLoops
    {
        public void PowerOfTwo()
        {
            Console.WriteLine("Please enter the number for a table of the power 2 !!!\n");

            int num = Convert.ToInt32(Console.ReadLine());
            int powerOfTwo = 1;

            for(int i = 1; i <= num; i++)
            {
                powerOfTwo = 2 * powerOfTwo;
                Console.WriteLine(i + " " + powerOfTwo);
            }
        }

        public void SumOfSquares()
        {
            Console.WriteLine("Enter the number to find the sum of squares!!!\n ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for( int i = 1; i <= num1; i++)
            {
                sum += (i * i);
            }
            Console.WriteLine("Sum of squares of " + num1 + " number is: " + sum);
        }

        public void Factorial()
        {
            Console.WriteLine("Enter the number to find the factorial of a number!!!\n ");

            int num2 = Convert.ToInt32(Console.ReadLine());

            int fact = 1;

            for (int i = 1; i <= num2; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
