﻿using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
            Console.WriteLine("Program is Complete");
        }
        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero.");
            string input = Console.ReadLine();
            int inputNum = Convert.ToInt32(input);
            int[] array = new int[inputNum];
            Populate(array);
            int sum = GetSum(array);
            int product = GetProduct(array,sum,inputNum);
            decimal quotient = GetQuotient(product);
            Console.WriteLine($"Your array size is: {inputNum}.");
            Console.Write("The numbers in your array are ");
            Console.Write(String.Join(",",array));
            Console.WriteLine($"The sum of your array is {sum}");
            int index = product / sum;
            Console.WriteLine($"{sum} * {index} = {product}");
            decimal divisor = product/quotient;
            Console.WriteLine($"{product}/{divisor} = {quotient}");

        }

        static int[] Populate(int[] array)
        {
            for ( int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a number between 1-10.");
                string input = Console.ReadLine();
                int inputNum = Convert.ToInt32(input);
                array[i] = inputNum;
            }
            return array;
        }
        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            if (sum < 20)
            {
                Console.WriteLine($"Value of {sum} is too low");
            }
            return sum;
        }
        static int GetProduct(int[] array,int sum,int x)
        {
            Console.WriteLine($"Select a number between 1 and {x-1}.");
            int product = 0;
            prompt:
            try
            {
                string input = Console.ReadLine();
                int inputNum = Convert.ToInt32(input);
                product = array[inputNum] * sum;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Try again");
                goto prompt;
            }
            return product;
            
        }

        static decimal GetQuotient(int product)
        {
            Console.WriteLine($"Enter a number to divide {product} by.");
            string input = Console.ReadLine();
            decimal inputNum = Convert.ToDecimal(input);
            decimal decimalProduct = Convert.ToDecimal(product);
            decimal quotient;
            try
            {
                quotient = decimal.Divide(decimalProduct, inputNum);
            }
            catch(DivideByZeroException ex)
            {
                return 0;
            }
            return quotient;
        }
    }
}
