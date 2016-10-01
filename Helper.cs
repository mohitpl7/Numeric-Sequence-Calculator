using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WNG_Test
{
    //Helper class
    public class Helper
    {
        //Function to call all the subfunctions for all numbers,even,odd,numbers with characters,
        //Fibonacci series and set properties of sequence class
        public Sequences GetNumericSequences(string num)
        {
            var objSequences = new Sequences();
            var number = Convert.ToInt32(num);
            objSequences.Numbers = GetAllNumbers(number);
            objSequences.EvenNumbers = GetAllEvenNumbers(number);
            objSequences.OddNumbers = GetAllOddNumbers(number);
            objSequences.NumbersWithCharacters = GetAllNumbersWithCharacters(number);
            objSequences.FibonacciNumbers = GetAllFibonacciNumbers(number);
            return objSequences;        
        }

        //Function to fetch all the number until a particular number.
        private string GetAllNumbers(int number)
        {
            string strNum = string.Empty;
            for (int i = 0; i <= number; i++)
            {
               strNum = strNum + Convert.ToString(i);
            }
            return strNum;
        }

        //Function to fetch all the odd number until a particular number.
        private string GetAllOddNumbers(int number)
        {
            string strNum = string.Empty;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                        strNum = strNum + Convert.ToString(i);
                }
            }
            return strNum;
        }

        //Function to fetch all the even number until a particular number.
        private string GetAllEvenNumbers(int number)
        {
            string strNum = string.Empty;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                     strNum = strNum + Convert.ToString(i);
                }
            }
            return strNum;
        }

        //Function to fetch all the number until a particular number and replace multiples of 3,5 by C, E & Z respectively.
        private string GetAllNumbersWithCharacters(int number)
        {
            string strNum = string.Empty;
            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    strNum = strNum + "Z";
                }
                else if (i % 3 == 0)
                {
                    strNum = strNum + "C";
                }
                else if (i % 5 == 0)
                {
                    strNum = strNum + "E";
                }                
                else
                {
                    strNum = strNum + Convert.ToString(i);
                }
            }
            return strNum;
        }

        //Function to fetch all the Fibonacci numbers until a particular number.
        private string GetAllFibonacciNumbers(int number)
        {
            string strNum = string.Empty;        
            int[] Fib = new int[number + 1];
            Fib[0] = 0;Fib[1] = 1;
            strNum = Convert.ToString(Fib[0]) +  Convert.ToString(Fib[1]);
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
                strNum = strNum + Convert.ToString(Fib[i]);
            }
            return strNum;
        }            
    }
}