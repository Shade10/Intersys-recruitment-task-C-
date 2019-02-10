using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewSolutions {
    public class ReverseArray {
        private string[] array;

        public ReverseArray() {
            MakeArray();
            Array.Reverse(array);
            GetArray();
        }

        public void MakeArray() {
            Console.WriteLine("Reverse Array - First number of N elements - enter and then your numbers in one line (splited by spacebar)");
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            IEnumerable<string> slice = input.Split(' ').Take(N);
            array = slice.ToArray();
        }

        public void GetArray() {
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
