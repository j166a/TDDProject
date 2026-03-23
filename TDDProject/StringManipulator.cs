using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class StringManipulator
    {
        public static string ReverseString(string input)
        {
            char[] inputToArray = input.ToCharArray();
            Array.Reverse(inputToArray);
            string reversedInput = new string(inputToArray);
            return reversedInput;
        }
        public static bool IsPalindrome(string input)
        {
            bool variable = input == ReverseString(input);
            return variable;
        }
    }
}
