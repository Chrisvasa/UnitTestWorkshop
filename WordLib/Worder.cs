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
            char[] inputChar = input.ToCharArray();
            inputChar.Reverse();

            if(input == inputChar.ToString())
            {
                return true;
            }

            return false;
        }
    }
}
