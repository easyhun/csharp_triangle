using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //왼쪽 삼각형
            int i = 0;
            while (i < 5)
            {
                int j = 0;
                while (j <= i)
                {
                    Write("*");
                    j++;
                }
                WriteLine();
                i++;
            }

            WriteLine();

            //왼쪽 거꾸로 삼각형
            i = 5;

            do
            {
                int j = 0;
                while (j < i)
                {
                    Write("*");
                    j++;
                }
                WriteLine();
                i--;
            }
            while (i > 0);

            WriteLine();

            //왼쪽 거꾸로 삼각형, do while문
            i = 0;
            do
            {
                int j = 0;
                while (i < 5 - j)
                {
                    Write("*");
                    j++;
                }
                WriteLine();
                i++;
            }
            while (i < 5);
            
            





        }
    }
}
