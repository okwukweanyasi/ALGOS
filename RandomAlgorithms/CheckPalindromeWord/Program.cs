using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckPalindromeWord
{
    class Program
    {
        //this code checks a given sets of words and returns if or not they are palindroms
        static void Main(string[] args)
        {
            string[] words = { "civic", "civic", "ivicc", "civil", "livci", "tmp", "ovo", "ooo", "aaaa", "aaaa8" };


        
            //foreach (var word in words)
            //{

            //    Console.WriteLine(word + " is palindrome?  " + isPalindrome(word) + "\n");
            //}
        }
     
        static bool isPalindrome(string inputString)
        {

            int oddCount = 0;



            var keyValues = inputString.ToLower().ToCharArray().GroupBy(k => k)

            .ToDictionary(g => g.Key, g => g.Count());



            foreach (var keyValue in keyValues)

            {

                if ((keyValue.Value % 2) != 0) //count is odd

                {

                    oddCount++;

                    if (oddCount > 1) // palindrome rule broken. Word cant be a palindrome

                        return false;

                }

            }

            return true;

        }
    }


}
