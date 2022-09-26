using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5! means 5 x 4 x 3 x 2 x 1

            // ask the user to enter n (an integer)
            Console.WriteLine("Welcome to Factorial Factory");
            Console.Write("Please enter a number: ");
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Please enter a number: ");
            }

            /*
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"{n}! = {factorial}");
            */

            int factorial = CalculateFactorial(n);

            Console.WriteLine($"{n}! = {factorial}");

        }

        static int CalculateFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }
    }
}
