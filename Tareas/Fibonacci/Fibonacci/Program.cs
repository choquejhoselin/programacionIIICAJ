﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {


        static void Main(string[] args)
        {

            FibonacciRecursiva x = new FibonacciRecursiva();
         
            for (int i =0; i <11 ; i++)
            {
                Console.WriteLine(x.fibonacci(i));

            }
            Console.ReadKey();

        }


       

    }
}
