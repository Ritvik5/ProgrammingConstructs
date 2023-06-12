using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BasicProgrammingConstructs
{
    public class SwitchCase
    {
        public void WeekDayName()
        {
            Console.WriteLine("Enter the Weekday Number to calculate Weekday Name : \n");
            Validate validate = new Validate();

            int dayNumber = Convert.ToInt32(Console.ReadLine());
            if (validate.Valid())
            {
                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Plese Enter Valid Input");
            }
        }
        public void Calculator()
        {
            Console.WriteLine("Enter two inputs to perform arithmaticc operations: \n");

            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nChoose options to perform arithmetic operations:\n1.Addition.\n2.Substarction.\n3.Multiplication.\n4.Division.");
            int options = Convert.ToInt32(Console.ReadLine());

            switch(options)
            {
                case 1:
                    Console.WriteLine("\n"+ (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("\n" + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("\n" + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("\n" + (num1 / num2));
                    break;
                default :
                    Console.WriteLine("Invalid options!!!");
                    break;
            }
        }
    }

    public class Validate
    {
        public int DayNum { get; set; }

        public bool Valid()
        {
            if (1<= DayNum || DayNum <=7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

   
}
