namespace BasicProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programming Constructs.\n");

            //IfAndElse.TwoNumAreEqual();
            //IfAndElse.IsEvenOrOdd();
            //IfAndElse.IsEligible();
            //IfAndElse.LargestOfThree();
            //IfAndElse.Eligibility();
            SwitchCase obj = new SwitchCase();
            //obj.WeekDayName();
            //obj.Calculator();
            ForLoops obj2 = new ForLoops();
            //obj2.PowerOfTwo();
            //obj2.SumOfSquares();
            //obj2.Factorial();
            WhileLoops obj3 = new WhileLoops();
            //obj3.FlipCoin20times();
            //obj3.ReverseWord();
            obj3.SumOfNaturalNumbers();
        }
    }
}