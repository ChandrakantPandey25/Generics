using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum
{
    class MaxString
    {
        public void MString()
        {
            Console.WriteLine("Enter the first string");

            string firstString = Console.ReadLine();
                int firstStrLength=firstString.Length;
            Console.WriteLine("Enter the second string");
            string secondString = Console.ReadLine();
            int secondStrLength = secondString.Length;
            
            Console.WriteLine("Enter the third string");
            string thirdString = Console.ReadLine();
            int thirdStrLength = thirdString.Length;
            
            if (firstStrLength > secondStrLength)
            {
                if (firstStrLength > thirdStrLength)

                {
                    Console.Write("Largest string is \n" + firstString);
                }
                else
                {
                    Console.Write("Largest string is \n" + thirdString);
                }
            }

            else if (secondStrLength > thirdStrLength)

                Console.Write("Largest string is \n" + secondString);

            else

                Console.Write("Largest string is \n" + thirdString);


        }
    }
}
