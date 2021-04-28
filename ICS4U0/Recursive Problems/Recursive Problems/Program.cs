using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Problems
{
    class Program
    {
        static void Main()
        {
            //CALL

            Console.WriteLine(RecursiveFibonacci(9));

            Console.ReadLine();
        }

        //Problem 1: Factorial
        //int to double to increase range of product (min 17 returns negative rn)

        static int IterativeFactorial(int n)
        {
            if (n < 0)      //Error
                return -1;

            int product = 1;
            for (int i = n; i > 0; i--)     //Unnecessary to *1
                product *= i;

            return product;
        }

        static int RecursiveFactorial(int n)
        {
            if (n == 0 | n == 1)
                return 1;
            else if (n < 0)     //Error
                return -1;

            return n * RecursiveFactorial(n - 1);
        }

        //Problem 2: Fibonacci

        static int IterativeFibonacci(int n)
        {
            if (n == 1 | n == 2)
                return 1;
            else if (n <= 0)     //Error
                return -1;

            int a, b = 1, c = 1;
            for (int i = 3; i <= n; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }

            return c;
        }

        static int RecursiveFibonacci(int n)
        {
            if (n == 1 | n == 2)
                return 1;
            else if (n <= 0)     //Error
                return -1;

            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        //Problem 3: Greatest Common Divider

        static int IterativeGCD(int x, int y)
        {
            if (x == 0 && y == 0)
                return -1;          //Error

            x = Math.Abs(x);
            y = Math.Abs(y);

            int z = 0;
            while (y > 0)
            {
                z = y;
                y = x % y;
                x = z;
            }

            return x;
        }

        static int RecursiveGCD(int x, int y)
        {
            if (x == 0 && y == 0)
                return -1;          //Error
            else if (y == 0)
                return x;

            x = Math.Abs(x);
            y = Math.Abs(y);

            return RecursiveGCD(y, x % y);

        }


        //Exercises page 6

        //1. Sum of intergers from 1 to n

        static int IterativeSum1N(int n)
        {
            if (n == 1)
                return 1;

            int sum = 0;
            if (n > 0)
                for (int i = 1; i <= n; i++)    //Positive
                    sum += i;
            else
                for (int i = 1; i >= n; i--)    //Negative
                    sum += i;

            return sum;
        }

        static int RecursiveSum1N(int n)
        {
            if (n == 1)
                return 1;
            else if (n > 0)
                return n + RecursiveSum1N(n - 1);   //Positive
            else
                return n + RecursiveSum1N(n + 1);   //Negative
        }

        //2. Sum of integers from m to n

        static int IterativeSumMN(int m, int n)
        {
            if (m == n)
                return 1;

            int sum = 0;
            if (n - m > 0)
                for (int i = m; i <= n; i++)    //Positive
                    sum += i;
            else
                for (int i = m; i >= n; i--)    //Negative
                    sum += i;

            return sum;
        }

        static int RecursiveSumMN(int m, int n)
        {
            if (m == n)
                return m;
            else if (n - m > 0)
                return m + RecursiveSumMN(m + 1, n);   //Positive
            else
                return m + RecursiveSumMN(m - 1, n);   //Negative
        }

        //3. Any term in the tribonacci sequence

        static int IterativeTribonacci(int n)
        {
            if (n <= 0)
                return -1;

            switch (n)
            {
                case 1:
                case 2:
                    return 1;
                case 3:
                    return 2;
                default:
                    int w, x = 1, y = 1, z = 2;
                    for (int i = 4; i <= n; i++)
                    {
                        w = x;
                        x = y;
                        y = z;
                        z = w + x + y;
                    }
                    return z;
            }
        }

        static int RecursiveTribonacci(int n)
        {
            if (n <= 0)
                return -1;

            switch (n)
            {
                case 1:
                case 2:
                    return 1;
                case 3:
                    return 2;
                default:
                    return RecursiveTribonacci(n - 3) + RecursiveTribonacci(n - 2) + RecursiveTribonacci(n - 1);
            }
        }
        
        //5. Value of a^n using fast exponentiation
        
        static int RecursiveFastExponentiation(int a, int n)
        {
            if (n < 0)
                return -1;
            else if (n == 0)
                return 1;
            else if (n == 1)
                return a;
            else
            {
                int result = RecursiveFastExponentiation(a, n / 2);

                if (n % 2 == 0)
                    return result * result;
                else
                    return result * result * a;
            }
        }
        
        //7. Smallest value of a series of numbers

        static int IterativeSmallestValue(List<int> numberList)
        {
            int smallest = numberList[0];

            for (int i = 1; i < numberList.Count; i++)
                if (smallest > numberList[i])
                    smallest = numberList[i];

            return smallest;
        }

        static int RecursiveSmallestValue(List<int> numberList, int size)
        {
            if (size == 1)
                return numberList[0];

            int smallestWithoutLast = RecursiveSmallestValue(numberList, size - 1);

            if (numberList[size - 1] < smallestWithoutLast)
                return numberList[size - 1];

            return smallestWithoutLast;
        }

        //9. Number of consonants in a string

        static int IterativeConsonantsCount(string text)
        {
            int consonants = 0;

            for (int i = 0; i < text.Length; i++)
                if ("aeiouAEIOU".IndexOf(text[i]) == -1)
                    consonants++;

            return consonants;                
        }

        static int RecursiveConsonantsCount(string text, int length)
        {
            if (length == 1)
                return ("aeiouAEIOU".IndexOf(text[length - 1]) >= 0) ? 0 : 1;

            return RecursiveConsonantsCount(text, length - 1) + (("aeiouAEIOU".IndexOf(text[length - 1]) >= 0) ? 0 : 1);

        }
        
    }
}
