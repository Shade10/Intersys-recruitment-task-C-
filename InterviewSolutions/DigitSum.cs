using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewSolutions {
    public class DigitSum {
        private int[] array;
        private int counter = 0;

        public DigitSum() {
            Console.WriteLine("Digit sum - First N numbers puted in array, next numbers in one line");
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            IEnumerable<string> slice = input.Split(' ').Take(N);
            array = slice.Select(s => int.Parse(s)).ToArray();

            countDigit(array);
        }

        void countDigit(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                int tmp = array[i].ToString().Length;
                if (tmp > counter) {
                    counter = tmp;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
