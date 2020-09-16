using System;

namespace FindMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //string val;
            //Console.Write("Enter integer: ");
            //val = Console.ReadLine();
            int[] numbers=   new int[] { 3, 7, 1, 2, 8, 4, 5 };

           int missingNo=  MissingNumber(numbers);

            Console.WriteLine($"The missing number is:{missingNo}");
            Console.WriteLine("Press any key to exit");
            string a = Console.ReadLine();

        }

        static int MissingNumber(int[] nosArrray)
        {
            int missingNo=0;

            Array.Sort(nosArrray);

            for (int i=0; i< nosArrray.Length-1; i++)
            {
                if ((nosArrray[i+1] - nosArrray[i]) > 1)
                {
                    missingNo = nosArrray[i] +1;
                }
            }

            return missingNo;
            ;
        }
    }
}
