using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_3
{
    internal class Program
    {
        //from Main function, called to ReverseString function
        public static string ReverseString(string input)
        {
            // I now understand arrays a lot more, the syntax confuses me a little, but I get the gist
            //turns input into an array, reverses said array
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            //turns the array BACK into a string, outputs it
            string reversedInput = new string(array);
            Console.WriteLine("The new string is: " + reversedInput);
            //returns with output. (This is what I understand least about the syntax, as I don't know why this is necessary. But it is, I know that.
            return reversedInput;
        }
        public static string CountVowels(string input)
        {
            //changes input to lowercase to keep it simple
            input = input.ToLower();
            int vowels = 0;
            int i = 0;
            //I've done this before, where it checks each characters for being a vowel and adds it to to vowels variable like a counter
            for (i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                { vowels++; }
            }
            Console.WriteLine("The amount of vowels is: " + vowels);
            return input;
        }
        public static string IsPalindrome(string input)
        {
            //Almost identical to ReverseString, where it swaps to array and back, and compares both states to see if they match
            input = input.ToLower();
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string palindrome = new string(chars);
            //If they match, it's a palindrome, and if not, it isn't. Simple!
            if (palindrome == input)
            {
                Console.WriteLine(palindrome + " is a palindrome!");
                    return palindrome;
            }
            else
            {
                Console.WriteLine(input + " is not a palindrome.");
                    return palindrome;
            }
            //Admittedly, when reading the instructions, it is unclear to me if it is ONLY checking for a palindrome or making a palindrome out of the input
            //So I did that code too, in case.
            /*
            string createdPalindrome = input + palindrome;
            Console.WriteLine("Your palindrome is " + createdPalindrome);
            return createdPalindrome;
            */

        }
        static void Main(string[] args)
        {
            //Gets string, asks for choice on operation
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Select an operation:");
            Console.WriteLine("(1 to reverse the string, 2 to count the vowels, or 3 to check for a palindrome!");
            int choice = Convert.ToInt32(Console.ReadLine());
            //if statement to filter into each method
            if (choice == 1 )
            {
                ReverseString(input);
                Console.ReadLine();
            }
            if (choice == 2)
            {
                CountVowels(input);
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                IsPalindrome(input);
                Console.ReadLine();
            }
            }
        }
    }
