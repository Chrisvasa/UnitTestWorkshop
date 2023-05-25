using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLib
{
    public class Worder
    {
        // Takes a string as input and then checks if that string is a palindrome
        public bool Palindrome(string input)
        {
            if(input.Length == 0)
            {
                throw new Exception("Empty string");
            }
            input = input.ToLower();
            // Turns input into a char array and then reverses it
            // Creates a string from the now reversed char array
            string output = new string(input.ToCharArray().Reverse().ToArray());
            // Checks if input is a palindrome or not
            if(input == output)
            {
                return true;
            }

            return false;
        }
    }
}
