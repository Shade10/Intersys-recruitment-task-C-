using System;
using System.Text.RegularExpressions;

namespace InterviewSolutions {
    public class Palindrome {
        private string input;

        public Palindrome() {
            Console.WriteLine("Palindrome Candidate: ");
            input = Console.ReadLine();
            Console.WriteLine(IsPalindrome(input) ? "YES" : "NO");
        }

        public bool IsPalindrome(string palindromeCandidate) {
            if (string.IsNullOrEmpty(palindromeCandidate)) {
                return true;
            }
            Regex nonAlphaChars = new Regex("[^a-z]");

            string alphaOnlyCandidate = nonAlphaChars.Replace(palindromeCandidate.ToLower(), "");

            int leftIndex = 0;
            int rightIndex = alphaOnlyCandidate.Length - 1;
            while (rightIndex > leftIndex) {
                if (alphaOnlyCandidate[leftIndex] != alphaOnlyCandidate[rightIndex]) {
                    return false;
                }
                leftIndex++;
                rightIndex--;
            }
            return true;
        }
    }


}
