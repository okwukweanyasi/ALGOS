using System;
using System.Collections.Generic;
using System.Linq;

namespace FindMissingNo
{
    class Program
    {
        // inputs 2 lists. L1, complete set of integers, L2, Duplicate of L2, missing 1. Return the missing Item
        //L1: 1,2,3,4,5,6//21

        //L2:3,4,5,6,2 //20
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> L1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> L2 = new List<int> { 1, 4, 5, 6, 2, 7, 8, 9 };

            Console.WriteLine(MissingNumber(L1, L2));
        }

        public static int MissingNumber(List<int> l1, List<int> l2)
        {
            int missingValue = 0;
            int l1Sum = l1.Sum();
            int l2Sum = l2.Sum();

            //Console.WriteLine("l1Sum: " +l1Sum);
            //Console.WriteLine("l2Sum: " +l2Sum);

            missingValue = l1Sum - l2Sum;

            return missingValue;
        }
    }
}
