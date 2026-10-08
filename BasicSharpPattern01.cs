using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProblems
{
    internal class BasicSharpPattern01
    {

        //*
        //**
        //***
        //****
        //*****

        public void PrintPattern(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
            }
        }

        public void PrintPattern02(int n)
        {
            for (int i = n; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void PrintPattern03(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
        }

        public void PrintPattern04(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }
        }

        public void PrintPattern05(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n - i; k++)
                {
                    Console.Write($" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"*");
                }

                Console.WriteLine();
            }
        }



    }
}
