﻿using System;
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
                Console.WriteLine("\n1.Even or Odd,");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        basic.CheckOfEvenOdd();
                        break;
                    case 2:
                        flag= false;
                        break;
                }
            }
        }
    }
}