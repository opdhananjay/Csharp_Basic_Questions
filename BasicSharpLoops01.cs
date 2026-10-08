using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProblems
{
    internal class BasicSharpLoops01
    {
        public void RunTest()
        {
            for(int i= 10; i >= 1; i--)
            {
                Console.WriteLine($"Line {i}");
            }

        }

        public void PrintEvenNumber()
        {
            for(int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) Console.WriteLine($"{i}");
            }
        }

        public void MultipleOfFive()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0) Console.WriteLine($"{i}");
            }
        }

        public void SumOfNumberOneToN(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0) sum += i;
            }

            Console.WriteLine($"{sum}");
        }

        public void PrintMultiplicationTable(int n)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }

        public void CalculateFactorial(int n)
        {
            int factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {n} is {factorial}");
        }

        public void PrintNumOfDigit(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine($"{count}");
        }

        public void SumOfDigit(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            Console.WriteLine($"{sum}");
        }

        public void ProductOfDigit(int n)
        {
            int product = 1;
            while (n > 0)
            {
                product *= n % 10;
                n = n / 10;
            }
            Console.WriteLine($"{product}");
        }


        public void ReverseOfNumber(int n)
        {
            int result = 0;
            while(n > 0)
            {
                int remainder = n % 10;
                result = result * 10 + remainder;
                n = n / 10;
            }
            Console.WriteLine($"{result}");
        }

        public void FindLargestDigit(int n)
        {
            int largest = 0;
            while (n > 0)
            {
                int remainder = n % 10;
                if (remainder > largest)
                {
                    largest = remainder;
                }
                n = n / 10;
            }
            Console.WriteLine($"Largest digit is {largest}");
        }

        public void FindSmallestDigit(int n)
        {
            int smallest = 0;
            while(n > 0)
            {
                int remainder = n % 10;
                if (smallest == 0 || remainder < smallest)
                {
                    smallest = remainder;
                }
                n = n / 10;
            }
            Console.WriteLine($"Smallest digit is {smallest}");
        }

    }
}
