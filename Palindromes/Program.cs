using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCase1 = "Stars";
            var testCase2 = "O, a kak Uwakov lil vo kawu kakao!";
            var testCase3 = "Some men interpret nine memos";

            var testCases = new List<string>
            {
                "Stars",
                "O, a kak Uwakov lil vo kawu kakao!",
                "Some men interpret nine memos"
            };

            foreach (var test in testCases)
            {
                var runTest = palindromeTest(test);
                Console.WriteLine(runTest ? $"{test} is a palindrome" : $"{test} is not a palindrome");
                
            }  
        }

        public static bool palindromeTest(string testCase)
        {
            var specialChar = new Regex("[^a-zA-Z0-9]");
            var removeSpecial = specialChar.Replace(testCase, "");
            var stringTransform = removeSpecial.ToLower();
            var stringReverse = stringTransform.Reverse().ToArray();
            var reverseToString = string.Join("", stringReverse);
            
            return reverseToString == stringTransform;
        }
    }
}