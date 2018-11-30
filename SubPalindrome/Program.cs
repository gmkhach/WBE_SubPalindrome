using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter a test string\n\n>>> ");
                    string input = Console.ReadLine().Trim();
                    Console.WriteLine("\nSubPalindrome: " + SubPalindrome(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static string SubPalindrome(string input)
        {
            string output = string.Empty;
            string reversedInput = string.Empty;
            Stack<char> myStack = new Stack<char>();
            int k;
            int l;
            string test = string.Empty;

            // reversing the input
            foreach (char ch in input)
            {
                myStack.Push(ch);
            }
            for (int i = 0; i < input.Length; i++)
            {
                reversedInput += myStack.Pop();
            }

            // comparing the input and the reversedInput strings
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j <= input.Length - i; j++)
                {
                    test = input.Substring(i, j);
                    if (reversedInput.Contains(test) && test.Length > output.Length)
                    {

                        output = test;
                    }
                }
            }

            return output;
        }
    }
}
