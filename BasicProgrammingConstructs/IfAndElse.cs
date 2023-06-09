using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConstructs
{
    public class IfAndElse
    {
        public static void TwoNumAreEqual()
        {
            Console.WriteLine("To check whether two integers are or not!!! \n");

            Console.WriteLine("Enter The First Number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter The Second Number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            if(firstNum == secondNum) 
            {
                Console.WriteLine("\nGiven Integers are Equal!!!");
            }
            else
            {
                Console.WriteLine("\nGiven Integers are not Equal!!!");
            }
        }

        public static void IsEvenOrOdd()
        {
            Console.WriteLine("To check whether the given number is Even or Odd!!!\n");

            Console.WriteLine("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num %2 == 0)
            {
                Console.WriteLine("\n"+ num + " is Even!!!");
            }
            else
            {
                Console.WriteLine("\n"+ num + " is Odd!!!");
            }
        }

        public static void IsEligible()
        {
            Console.WriteLine("To check whether you are eligible to vote or not!!!\n");

            Console.WriteLine("Enter the Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >=18)
            {
                Console.WriteLine("\nYou are Eligible to Vote!!!");
            }
            else
            {
                Console.WriteLine("\nYou are not Eligible to Vote!!!");
            }

        }
    }
}
