using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsPalindrome(string someWord )
        { 

        string reversedWord = "";

            for (int i = someWord.Length-1; i >= 0; i--)
            {
                reversedWord += someWord[i];

            }
            if (reversedWord == someWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
