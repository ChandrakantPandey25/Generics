using System;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Program");
            Console.WriteLine("Enter 1 for Maximum of three integers");
            Console.WriteLine("Enter 2 for Maximum of three float numbers");
            Console.WriteLine("Enter 3 for Maximum of three strings");

            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    MaxOfInteger largestNum = new MaxOfInteger();
                    largestNum.Integer();
                    break;
                case 2:
                    MaxFloat largestFNum = new MaxFloat();
                    largestFNum.FloatNum();
                    break;
                case 3:
                    MaxString largestSNum = new MaxString();
                    largestSNum.MString();
                    break;
                default:
                    Console.WriteLine("Enter Valid number!!");
                    break;

            }
        }
    }
}
