using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordLib
{
    public class Worder
    {
        // Takes a string as input and then checks if that string is a palindrome
        public bool Palindrome(string input)
        {
            if(String.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Empty string");
            }

            input = input.ToLower();
            // Turns input into a char array and then reverses it
            // Creates a string from the now reversed array of chars
            string output = new string(input.ToCharArray().Reverse().ToArray());

            // Checks if input is a palindrome or not
            if(input == output)
            {
                return true;
            }

            return false;
        }

        public string Sorter(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Empty string");
            }
            // Regex that includes the allowed chars
            bool match = Regex.IsMatch(input, "^[a-zA-Z]*$");
            // If string has invalid chars, returns an exception
            if(!match)
            {
                throw new Exception("Invalid input");
            }
            // Turns input into lowercase, then creates an array and sorts that char array before returning it as a new string
            input = input.ToLower();
            char[] chars = input.ToArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}
