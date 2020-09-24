using System;
using System.Collections.Generic;

namespace FindDuplicateNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 1,3, 2, 8, 4, 5,6 };
            int[] numbers1 = new int[] { 3, 7, 1, 8, 2, 4, 5, 6,8 };
            int[] numbers2 = new int[] { 6, 7, 11, 3, 24, 8, 11, 35, 6 };

            int duplicateNo = DuplicateNo(numbers);

            Console.WriteLine($"The duplicate number is:{duplicateNo}");

            int duplicateNo1 = DuplicateNo(numbers1);

            Console.WriteLine($"The duplicate number is:{duplicateNo1}");


            int duplicateNo2 = DuplicateNo(numbers2);

            Console.WriteLine($"The duplicate number is:{duplicateNo2}");
            Console.WriteLine("Press any key to exit");
            string a = Console.ReadLine();
        }

        static int DuplicateNo(int[] nosArray)
        {
            int duplicate;
            Dictionary<int, int> numbersDictionary = new Dictionary<int, int>();

            for(int i = 0; i< nosArray.Length; i++)
            {
                if (numbersDictionary.ContainsKey(nosArray[i]))
                {
                    duplicate = nosArray[i];
                    return duplicate;
                }
                else
                {
                    numbersDictionary.Add(nosArray[i], nosArray[i]);
                }
            }

            return default;

        }
    }
}
