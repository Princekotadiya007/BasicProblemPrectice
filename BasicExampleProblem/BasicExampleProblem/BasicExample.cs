﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExampleProblem
{
    public class BasicExample
    {
        public void CheckOfEvenOdd()
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        public void OddNumberRange()
        {
            Console.WriteLine("Enter the First Number");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Last Number");
            int end = Convert.ToInt32(Console.ReadLine());

            for(int i=start; i<end; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine("Odd Number :" + i + " ");
                }
            }
            Console.ReadLine();
        }
        public void NagativeOrNot()
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine(num + " " + "it is positive");
            }
            else
            {
                Console.WriteLine(num + " " + "it is Nagative");
            }
        }
        public void LargestNumber()
        {
            Console.WriteLine("Enter the first Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine(num1 + " " + "Num1 is largest number");
            }
            else
            {
                Console.WriteLine(num2 + " " + " Num2 is largest number");
            }
        }
    }
}
