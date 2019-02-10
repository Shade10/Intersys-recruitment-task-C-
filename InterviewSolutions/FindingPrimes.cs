using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewSolutions {
    partial class Program {
        public class FindingPrimes {
            private int counter;
            private const int RangeElements = 2;
            private int[] array = new int[RangeElements];
            private readonly Dictionary<string, int> primeList = new Dictionary<string, int>();

            public FindingPrimes() {
                Console.WriteLine("Finding prime numbers - First T number of test case, and next range of numbers - splited by spacebar");
                int inputTestCase = int.Parse(Console.ReadLine());

                addToDictionary(inputTestCase);
                Console.WriteLine();
                GetCounter();
            }

            void counterPrimeNumbers(int m, int n) {
                counter = 0;
                for (int i = m; i < n; i++) {
                    int tmp = 0;
                    if (i > 1) {
                        for (int j = 2; j < i; j++) {
                            if (i % j == 0) {
                                tmp = 1;
                                break;
                            }
                        }
                        if (tmp == 0) {
                            counter++;
                        }
                    }
                }
            }

            public void addToDictionary(int howManyElements) {

                for (int i = 0; i < howManyElements; i++) {
                    string input = Console.ReadLine();
                    string tmp = "";

                    IEnumerable<string> slice = input.Split(' ').Take(RangeElements);
                    array = slice.Select(s => int.Parse(s)).ToArray();

                    tmp = array[0].ToString() + " " + array[1].ToString();
                    counterPrimeNumbers(array[0], array[1]);
                    primeList.Add(tmp, counter);
                }
                array = Array.Empty<int>();
            }

            public void GetCounter() {
                foreach (var item in primeList)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
