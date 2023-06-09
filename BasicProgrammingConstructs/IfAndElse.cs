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

        public static void LargestOfThree()
        {
            Console.WriteLine("To find the largest of three numbers!!!\n");

            Console.WriteLine("Enter the First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the Third Number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if( num1 > num2 && num1 > num3)
            {
                Console.WriteLine("\n" + num1 + " is largest of three!!!");
            }
            else if( num2 > num1 && num2 > num3)
            {
                Console.WriteLine("\n" + num2 + " is largest of three!!!");
            }
            else
            {
                Console.WriteLine("\n" + num3 + " is largest of three!!!");
            }
        }

        public static void Eligibility()
        {
            Console.WriteLine("To Find the eligibility of admission for a professional course!!!\n");

            Console.WriteLine("Enter the marks in maths: ");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the marks in physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the marks in chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            int totalMarks = math + physics + chemistry;
            Console.WriteLine("\nTotal marks is: " + totalMarks);

            if (math >= 65)
            {
                if (physics >= 55)
                {
                    if (chemistry >= 50)
                    {
                        if(totalMarks>=180 || (math + physics) >= 140)
                        {
                            Console.WriteLine("The candidate is eligible for admission!!!");
                        }
                        else
                        {
                            Console.WriteLine("The candidate is not eligilbe for admission!!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The candidate is not eligilbe for admission!!!");
                    }
                }
                else
                {
                    Console.WriteLine("The candidate is not eligilbe for admission!!!");
                }
            }
            else
            {
                Console.WriteLine("The candidate is not eligilbe for admission!!!");
            }
        }
    }
}
