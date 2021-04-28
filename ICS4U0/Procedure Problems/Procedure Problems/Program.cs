using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedure_Problems
{
    class Program
    {
        static void Main()
        {
            //CALL
            LongestCommonSubsequence();
        }

        //Page 20

        //1.Determine whether a given number is prime
        static void DeterminePrime()
        {
            Console.WriteLine("Enter a number");

            while (true)
            {
                string inputString = Console.ReadLine(), primeOrNot = "Prime";

                bool isNumeric = int.TryParse(inputString, out int number);

                if (isNumeric)
                {
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            primeOrNot = "Not Prime";
                            break;
                        }
                    }

                    Console.WriteLine(primeOrNot);
                }
                else
                    Environment.Exit(0);
            }
        }

        //4.Compute the distance between any two points
        static void ComputeDistanceBetweenPoints()
        {
            Console.WriteLine("Enter coordinates x1,y1,x2,y2");

            while (true)
            {
                string inputString = Console.ReadLine();

                List<string> actualCoordinates = new List<string>(inputString.Split(',').ToList());     //no check to see if list is numbers

                int x1 = Convert.ToInt32(actualCoordinates[0]), y1 = Convert.ToInt32(actualCoordinates[1]),
                    x2 = Convert.ToInt32(actualCoordinates[2]), y2 = Convert.ToInt32(actualCoordinates[3]);

                double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                Console.WriteLine(distance.ToString());
            }
        }

        //5.Determine whether any given year is a leap year
        static void DetermineLeapYear()
        {
            Console.WriteLine("Enter a year");

            while (true)
            {
                string inputString = Console.ReadLine(), leapYearOrNot = "Not a leap year";

                bool isNumeric = int.TryParse(inputString, out int year);

                if (isNumeric)
                {
                    if (year % 4 == 0 && !(year % 100 == 0 && year % 400 != 0))
                        leapYearOrNot = "Leap year";

                    //if (year % 4 != 0)
                    //    leapYearOrNot = "Common year";
                    //else if (year % 100 != 0)
                    //    leapYearOrNot = "Leap year";
                    //else if (year % 400 != 0)
                    //    leapYearOrNot = "Common year";
                    //else
                    //    leapYearOrNot = "Leap year";

                    Console.WriteLine(leapYearOrNot);
                }
                else
                    Environment.Exit(0);
            }
        }

        //Page 37

        //1.Reverse the items in a list
        static void ReverseItemsInList()
        {
            Console.WriteLine("Enter list a,b,c...");

            while (true)
            {
                string inputString = Console.ReadLine();

                List<string> actualList = new List<string>(inputString.Split(',').ToList());

                for (int i = 0; i < actualList.Count / 2; i++)
                {
                    string copy = actualList[i];
                    actualList[i] = actualList[actualList.Count - 1 - i];
                    actualList[actualList.Count - 1 - i] = copy;
                }

                //Anush

                //for (int i = actualList.Count - 2; i > -1; i--)
                //{
                //    actualList.Add(actualList[i]);
                //    actualList.RemoveAt(i);
                //}

                Console.WriteLine(String.Join(", ", actualList));
            }
        }

        //2.Find the sum of the first n items of a list
        static void SumOfFirstItems()
        {
            Console.WriteLine("Enter list of numbers a,b,c... THEN number of items");

            while (true)
            {
                string inputString = Console.ReadLine();

                List<string> actualList = new List<string>(inputString.Split(',').ToList());        //no check to see if list is numbers

                inputString = Console.ReadLine();

                bool isNumeric = int.TryParse(inputString, out int actualNumber);

                if (isNumeric)
                {
                    int number, sum = 0;

                    for (int i = actualNumber - 1; i > -1; i--)
                    {
                        number = Convert.ToInt32(actualList[i]);
                        sum += number;
                    }

                    Console.WriteLine(sum);
                }
                else
                    Environment.Exit(0);
            }
        }

        //3.Find the sum of n consecutive items in a list, starting with item i
        static void SumOfConsecutiveItems()
        {
            Console.WriteLine("Enter list of numbers a,b,c... THEN number of items THEN starting position");

            while (true)
            {
                string inputString = Console.ReadLine();

                List<string> actualList = new List<string>(inputString.Split(',').ToList());        //no check to see if list is numbers

                inputString = Console.ReadLine();

                bool isNumeric = int.TryParse(inputString, out int actualItems);

                if (isNumeric)
                {
                    inputString = Console.ReadLine();

                    isNumeric = int.TryParse(inputString, out int actualPosition);

                    if (isNumeric)
                    {
                        if (actualPosition + actualItems > actualList.Count)
                            actualItems = actualList.Count - actualPosition + 1;

                        int number, sum = 0;

                        for (int i = actualPosition - 1; i < actualPosition - 1 + actualItems; i++)
                        {
                            number = Convert.ToInt32(actualList[i]);
                            sum += number;
                        }

                        Console.WriteLine(sum);
                    }
                    else
                        Environment.Exit(0);
                }
                else
                    Environment.Exit(0);
            }
        }

        //4.Return a new list consisting of the odd-indexed items of a given list
        static void ReturnOddIndicesOfList()
        {
            Console.WriteLine("Enter list of numbers a,b,c...");

            while (true)
            {
                string inputString = Console.ReadLine();

                List<string> actualList = new List<string>(inputString.Split(',').ToList());    //no check to see if list is numbers

                List<string> oddItems = new List<string>();

                for (int i = 1; i < actualList.Count; i += 2)
                    oddItems.Add(actualList[i]);

                Console.WriteLine(string.Join(", ", oddItems));
            }
        }

        //5.Combine two lists by alternatingly taking items from each list
        static void CombineListsAlternatingly()
        {
            Console.WriteLine("Enter list a,b,c... THEN list d,e,f...");

            while (true)
            {
                string inputString = Console.ReadLine();

                List<string> actualList1 = new List<string>(inputString.Split(',').ToList());

                inputString = Console.ReadLine();

                List<string> actualList2 = new List<string>(inputString.Split(',').ToList());

                List<string> actualList = new List<string>();

                int minListLength = 0;

                if (actualList1.Count > actualList2.Count)
                    minListLength = actualList2.Count;
                else
                    minListLength = actualList1.Count;

                for (int i = 0; i < minListLength; i++)
                {
                    actualList.Add(actualList1[0]);
                    actualList.Add(actualList2[0]);

                    actualList1.RemoveAt(0);
                    actualList2.RemoveAt(0);
                }

                actualList.AddRange(actualList1);
                actualList.AddRange(actualList2);

                Console.WriteLine(string.Join(", ", actualList));
            }
        }

        //6.Merge two sorted lists into one sorted list
        static void MergeSortedLists()
        {
            Console.WriteLine("Enter list of numbers a,b,c... THEN list of numbers d,e,f...");

            while (true)
            {
                string inputString = Console.ReadLine();

                List<string> actualList1 = new List<string>(inputString.Split(',').ToList());       //no check to see if list is numbers

                inputString = Console.ReadLine();

                List<string> actualList2 = new List<string>(inputString.Split(',').ToList());       //no check to see if list is numbers

                actualList1.AddRange(actualList2);

                actualList1.Sort();     //or sort algorithm

                Console.WriteLine(string.Join(", ", actualList1));
            }
        }

        //7.Rotate the items of a list by k items
        static void RotateItemsOfList()
        {
            Console.WriteLine("Enter list a,b,c... THEN number of items to rotate");

            while (true)
            {
                string inputString = Console.ReadLine();

                List<string> actualList = new List<string>(inputString.Split(',').ToList());

                inputString = Console.ReadLine();

                bool isNumeric = int.TryParse(inputString, out int actualItems);

                if (isNumeric)
                {
                    if (actualItems > 0)
                    {
                        for (int i = 0; i < actualItems; i++)
                        {
                            actualList.Insert(0, actualList[actualList.Count - 1]);
                            actualList.RemoveAt(actualList.Count - 1);
                        }
                    }
                    else
                    {
                        for (int i = 0; i > actualItems; i--)
                        {
                            actualList.Add(actualList[0]);
                            actualList.RemoveAt(0);
                        }
                    }

                    Console.WriteLine(string.Join(", ", actualList));
                }
                else
                    Environment.Exit(0);
            }
        }

        //8.Take an integer and return a list of its digits
        static void ReturnListOfDigits()
        {
            Console.WriteLine("Enter integer");

            while (true)
            {
                string inputString = Console.ReadLine();

                bool isNumeric = int.TryParse(inputString, out int integer);

                if (isNumeric)
                {
                    List<char> actualList = new List<char>();

                    for (int i = 0; i < inputString.Length; i++)
                        actualList.Add(inputString[i]);

                    Console.WriteLine(string.Join(", ", actualList));
                }
                else
                    Environment.Exit(0);
            }
        }

        //9.Translate English text to Pig Latin and vice versa          TODO VICE VERSA - PROBLEM IS WORDS LIKE TRAY
        static void TranslateEnglishToPigLatin()
        {
            Console.WriteLine("Enter English text");

            while (true)
            {
                string inputString = Console.ReadLine();

                int start = 0;

                if (char.IsLetter(inputString[inputString.Length - 1]))
                    inputString = inputString.Insert(inputString.Length, " ");

                for (int i = 0; i < inputString.Length; i++)
                {
                    if (!char.IsLetter(inputString[i]))
                    {
                        inputString = inputString.Insert(i, inputString[start].ToString() + "ay");
                        inputString = inputString.Remove(start, 1);

                        i = start = i + 3;
                    }
                }

                Console.WriteLine(inputString);
            }
        }

        //10.Translate English text to Morse Code and vice versa
        static void TranslateEnglishToMorse()
        {
            Console.WriteLine("Enter English text or Morse Code");

            while (true)
            {
                string inputString = Console.ReadLine().ToLower();

                string translatedString = "";

                Dictionary<char, string> translator = new Dictionary<char, string>()
                    {
                        {'a', ".-"}, {'b', "-..."}, {'c', "-.-."}, {'d', "-.."}, {'e', "."}, {'f', "..-."}, {'g', "--."},
                        {'h', "...."}, {'i', ".."}, {'j', ".---"}, {'k', "-.-"}, {'l', ".-.."}, {'m', "--"}, {'n', "-."},
                        {'o', "---"}, {'p', ".--."}, {'q', "--.-"}, {'r', ".-."}, {'s', "..."}, {'t', "-"}, {'u', "..-"}, {'v', "...-"},
                        {'w', ".--"}, {'x', "-..-"}, {'y', "-.--"}, {'z', "--.."},
                        {' ', "/"}, {',', ","}, {'.', "."}, {'!', "!"}, {'?', "?"},
                        {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."},
                        {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."}, {'0', "-----"}
                    };

                if (inputString.Length > 0)
                {
                    if (char.IsLetterOrDigit(inputString[0]))
                    {
                        for (int i = 0; i < inputString.Length; i++)
                            translatedString += translator[inputString[i]] + " ";
                    }
                    else
                    {
                        if (!char.IsSeparator(inputString[inputString.Length - 1]))
                            inputString = inputString.Insert(inputString.Length, " ");

                        string code = "";

                        for (int i = 0; i < inputString.Length; i++)
                        {
                            if (inputString[i] != ' ')
                            {
                                code += inputString[i];
                            }
                            else
                            {
                                foreach (KeyValuePair<char, string> pair in translator)
                                    if (pair.Value == code)
                                        translatedString += pair.Key;

                                code = "";
                            }
                        }
                    }
                }

                Console.WriteLine(translatedString);
            }
        }

        //11.Find the longest palindromic substring of a given string
        static void LongestPalindromeSubstring()
        {
            Console.WriteLine("Enter word");

            while (true)
            {
                string inputString = "." + Console.ReadLine().ToLower() + ",", longestPalindrome = "";

                for (int i = 1; i < inputString.Length - 2; i++)
                {
                    for (int x = i - 1, y = i + 1; x > -1 && y < inputString.Length; x--, y++)
                    {
                        if (inputString[x] != inputString[y])
                        {
                            if (longestPalindrome.Length + 1 < y - x)
                            {
                                longestPalindrome = inputString.Substring(x + 1, y - x - 1);
                            }
                            break;
                        }
                    }
                }

                for (int i = 0; i < inputString.Length - 2; i++)
                {
                    if (inputString[i] == inputString[i + 1])
                    {
                        for (int x = i - 1, y = i + 2; x > -1 && y < inputString.Length; x--, y++)
                        {
                            if (inputString[x] != inputString[y])
                            {
                                if (longestPalindrome.Length + 1 < y - x)
                                {
                                    longestPalindrome = inputString.Substring(x + 1, y - x - 1);
                                }
                                break;
                            }
                        }
                    }
                }

                Console.WriteLine(longestPalindrome);
            }
        }

        //12.Given two strings, efficiently find the longest common subsequence
        static void LongestCommonSubsequence()
        {
            Console.WriteLine("Enter first word THEN next word");

            while (true)
            {
                string inputString1 = Console.ReadLine().ToLower() + ".", inputString2 = Console.ReadLine().ToLower() + ",", longestSubsequence = "";

                int string2startIndex = -1;

                bool end;

                for (int i = 0; i < inputString1.Length; i++)
                {
                    end = true;

                    while (end)
                    {
                        string2startIndex = inputString2.IndexOf(inputString1[i], string2startIndex + 1);

                        if (string2startIndex != -1)
                        {
                            for (int index1 = i + 1, index2 = string2startIndex + 1; index1 < inputString1.Length && index2 < inputString2.Length; index1++, index2++)
                            {
                                if (inputString1[index1] != inputString2[index2])
                                {
                                    if (longestSubsequence.Length < index1 - i)
                                    {
                                        longestSubsequence = inputString1.Substring(i, index1 - i);
                                    }
                                    break;
                                }
                            }
                        }
                        else
                            end = false;
                    }
                }

                if (longestSubsequence.Length == 0)
                    longestSubsequence = "N/A";

                Console.WriteLine(longestSubsequence);
            }
        }
        
    }
}
