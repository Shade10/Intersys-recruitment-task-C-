using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewSolutions {
    public class ExistingPowersOfTwo {
        private List<uint> uintArrayOne;
        private List<uint> uintArrayTwo;
        private List<uint> uintArrayThree;

        private List<uint> tmpList;

        public ExistingPowersOfTwo() {
            uintArrayOne = new List<uint>();
            uintArrayOne.Add(1);
            uintArrayOne.Add(3);
            uintArrayOne.Add(4);

            uintArrayTwo = new List<uint>();
            uintArrayTwo.Add(3);
            uintArrayTwo.Add(1);
            uintArrayTwo.Add(2);


            uintArrayThree = new List<uint>();
            uintArrayThree.Add(3);
            uintArrayThree.Add(5);
            uintArrayThree.Add(7);

            Console.WriteLine("Existing powers of 2");

            SetPowers(uintArrayOne);
            GetInfoOfArray(tmpList);
            Console.WriteLine("\n");
            SetPowers(uintArrayTwo);
            GetInfoOfArray(tmpList);
            Console.WriteLine("\n");
            SetPowers(uintArrayThree);
            GetInfoOfArray(tmpList);
        }

        public void SetPowers(List<uint> list) {
            tmpList = new List<uint>();
            uint tmp = 0;
            list.Sort();
            list.Distinct();

            foreach (var item in list) {
                if (item == 1 || item % 2 == 0) {
                    tmp = item;
                }
            }

            if (tmp > 0) {
                for (uint i = 1; i <= list.Max(); i++) {
                    if (i == 1 || i % 2 == 0) {
                        tmpList.Add(i);
                    }
                }
            }
        }

        public void GetInfoOfArray(List<uint> list) {
            if (list.Count > 0) {
                foreach (var item in list) {
                    Console.Write(item + ", ");
                }
            } else {
                Console.WriteLine("NA");
            }
        }
    }
}
