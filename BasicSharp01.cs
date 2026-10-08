using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProblems
{
    public class BasicSharp01
    {
        public void RunTest()
        {
            Console.WriteLine("Run Test");
        }

        public int AddTwoNumbers(int a,int b)
        {
            return a + b;
        }

        public int SubtractTwoNumbers(int a,int b)
        {
            return a - b;
        }

        public int MultiplyTwoNumbers(int a,int b)
        {
            return a * b;
        }

        public double DivideTwoNumbers(int a,int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return (double)a / b;
        }

        public void MathFunctions()
        {
            Math.Abs(-5); // Returns 5
            Math.Ceiling(4.2); // Returns 5
            Math.Floor(4.8); // Returns 4
            Math.Max(5, 10); // Returns 10
            Math.Min(5, 10); // Returns 5
            Math.Round(10.7); // Returns 11
            Math.Round(10.3); // Returns 10
            Math.Sqrt(16); // Returns 4
            Math.Cbrt(27); // Returns 3
        }

        public void ConceptOne()
        {
            string a1 = "20";
            int.Parse(a1); // Returns 20

            string b1 = "20.5";
            double.Parse(b1); // Returns 20.5
        }

        public decimal RemainderTwoNumber()
        {
            return 10 % 2;
        }

        public decimal CalculateSimpleInterest(decimal principal,decimal rate,decimal time)
        {
            decimal simpleInterest = (principal * rate * time) / 100m;
            decimal totalAmount = principal + simpleInterest;
            return totalAmount;
        }

        public decimal CalculateAreaOfCircle(decimal radius)
        {
            decimal area = (decimal)Math.PI * radius * radius;
            return area;
        }

        public double CalculateCelsiusToFarenhit(double celsius)
        {
            double farenhit = (celsius * 9 / 5) + 32;
            return farenhit;
        }

        // Swap Two Variable Using Temporary Variable - 
        public void SwapTwoVariableUsingTempVariable()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"{a} | {b}");
            int? temp = null;
            temp = a;
            a = b;
            b = temp.Value;
            Console.WriteLine($"{a} | {b}");
        }


        // Swap Two Number Without Temporary Variable - 
        public void SwapTwoVariableWithoutTempVariable()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"{a} | {b}");
            a = a + b; // 30
            b = a - b; // 30 - 20 = 10
            a = a - b; // 30 - 10 = 20
            Console.WriteLine($"{a} | {b}");
        }

        // Convert Minute Into Hour and remaining Minute - 

        public void ConvertMinutesIntoHour(int minutes)
        {
            // 1 Hour = 60 Min 
            int hour = minutes / 60;
            int remainingMinutes = minutes % 60;
            Console.WriteLine($"{minutes} minutes convert into {hour} hours and {remainingMinutes} minutes");
        }

        // Convert Decimal To Binary
        public string ConvertDecimalToBinary(int decimalNumber) 
        {
            return Convert.ToString(decimalNumber, 2);
        }

        public int ConvertBinaryToDecimal(string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        // Check Number is positive or negative 
        public string CheckPostiveNegOrZero(int number)
        {
            if (number == 0) return "Zero";
            if (number > 0) return "Postive";
            return "Negative";
        }

        public int largestOfThreeNum(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if(b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        
        public bool CheckLeapYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("Leap Year");
                return true;
            }
            else
            {
                Console.WriteLine("Not Leap Year");
                return false;
            }
        }

        // Create Simple Calculator using switch case - 
        public void SimpleCalculator(int a,int b,char operation)
        {
            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{a} + {b} = {a + b}"); break;
                case '-':
                    Console.WriteLine($"{a} - {b} = {a - b}"); break;
                case '*':
                    Console.WriteLine($"{a} * {b} = {a * b}"); break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = {(double)a / b}");
                    }
                    break;
            }
        }
    }
}
