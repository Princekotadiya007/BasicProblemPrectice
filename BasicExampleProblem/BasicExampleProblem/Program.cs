using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExampleProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            BasicExample basic = new BasicExample();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Basic Problem Example");
                Console.WriteLine("\n1.Even or Odd,\n2.Odd Number Range, \n3.PositiveOrNot,\n4 largest Number\n5.SwapNumber,\n6.Divisible By 2,\n7.Sum of multiple 3 to 5,\n8.Multiple of 17, \n9.Sum of Digits, \n10.Reverse Number, \n11..Reverse Of Palindrome ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        basic.CheckOfEvenOdd();
                        break;
                    case 2:
                        basic.OddNumberRange();
                        break;
                    case 3:
                        basic.NagativeOrNot();
                        break;
                    case 4:
                        basic.LargestNumber();
                        break;
                    case 5:
                        basic.SwapNumber();
                        break;
                    case 6:
                        basic.Divisible();
                        break;
                    case 7:
                        basic.SumOfMultiple();
                        break;
                    case 8:
                        basic.PrintMultiples();
                        break;
                    case 9:
                        basic.SumDigits();
                        break;
                    case 10:
                        basic.Reverse();
                        break;
                    case 11:
                        basic.ReverseOfPalindrome();
                        break;
                    case 12:
                        flag= false;
                        break;
                }
            }
        }
    }
}
