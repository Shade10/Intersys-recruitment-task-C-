using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewSolutions {
    partial class Program {
        public class Permutation {
            private const int sizeOfArrays = 11;
            private int[] arrayOne = new int[sizeOfArrays];
            private int[] arrayTwo = new int[sizeOfArrays];

            public Permutation() {
                makeArrays();
                Console.WriteLine(arePermutations() ? "YES" : "NO");
            }

            private bool arePermutations() {
                int sum1 = 0, sum2 = 0,
                    mul1 = 1, mul2 = 1;

                for (int i = 0; i < arrayOne.Length; i++) {
                    sum1 += arrayOne[i];
                    mul1 *= arrayOne[i];
                }

                for (int i = 0; i < arrayTwo.Length; i++) {
                    sum2 += arrayTwo[i];
                    mul2 *= arrayTwo[i];
                }
                return ((sum1 == sum2) && (mul1 == mul2));
            }

            private void makeArrays() {
                Console.WriteLine("Permutation - Your two arrays per line (splited by spacebar in line): ");
                string input = Console.ReadLine();
                string inputTwo = Console.ReadLine();

                try {
                    IEnumerable<string> slice = input.Split(' ').Take(sizeOfArrays);
                    arrayOne = slice.Select(s => int.Parse(s)).ToArray();

                    IEnumerable<string> sliceTwo = inputTwo.Split(' ').Take(sizeOfArrays);
                    arrayTwo = sliceTwo.Select(s => int.Parse(s)).ToArray();
                } catch (Exception e) {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }


}
