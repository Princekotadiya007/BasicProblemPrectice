using System;
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
        public void SwapNumber()
        {
            Console.WriteLine("Enter the first Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Swap Number : Number 1 :" +num1+ " " + "Number 2 :" + num2);
        }
        public void Divisible()
        {
            Console.WriteLine("Enter the Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine(num + "it is divisible");
            }
            else
            {
                Console.WriteLine(num + " it is not divisible");
            }
        }
        public void SumOfMultiple()
        {
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i =1; i<num; i++)
            {
                if(i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
                Console.WriteLine("The sum of all multiples of 3 and 5 is" + sum);
            }
        }
        public void PrintMultiples()
        {
            Console.WriteLine("Enter the Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<num; i++)
            {
                int multiple = i * 17;
                if(multiple < 100)
                {
                    Console.WriteLine(multiple);
                }
            }
        }
        public void SumDigits()
        {
            Console.WriteLine(" Enter the Number :");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while(sum != 0)
            {
                int temp = num % 10;
                sum += temp;
                num = num / 10;
            }
            Console.WriteLine("sum of digits" + sum);
        }
        public void Reverse()
        {
            Console.WriteLine(" Enter the Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while(num > 0)
            {
                int temp = num % 10;
                reverse = reverse * 10 + temp;
                num = num / 10;
            }
            Console.WriteLine("Reverse Number :" + reverse);
        }
        public void ReverseOfPalindrome()
        {
            Console.WriteLine(" Enter the Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            int temp = num;

            while (temp > 0)
            {
                int digit = temp % 10;
                reverse = reverse * 10 + digit;
                temp = temp / 10;
            }
            Console.WriteLine("The reversed number is: " + reverse);

            if (reverse == num)
            {
                Console.WriteLine("The number is a palindrome");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
        }
    }
}
