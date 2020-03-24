using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciRecursiva
    {
        public int fibonacci(int n)
        {

            if (n == 0)
            {
                return 0;
            }
            
            else if (n == 1)
            {
                return 1;
            }
            
               
            else if (n < 2)
            {
                return n;
            }
            
              
            
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
            
                
            
        }
    }
}
