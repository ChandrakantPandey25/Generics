﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum
{
    class MaxFloat
    {
        public void FloatNum()
        {
            double num1, num2, num3;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number");
            num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)

                {
                    Console.Write("Largest number is \n" + num1);
                }
                else
                {
                    Console.Write("Largest number is \n" + num3);
                }
            }

            else if (num2 > num3)

                Console.Write("Largest number is \n" + num2);

            else

                Console.Write("Largest number is \n" + num3);


        }
    }
}
