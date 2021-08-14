using System;

namespace FIndDuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 1, 3, 2, 8, 4, 5, 6 };
            int[] numbers1 = new int[] { 3, 7, 1, 8, 2, 4, 5, 6, 8 };
            int[] numbers2 = new int[] { 3,10, 7,4, 1, 2, 4,9, 5, 6, 8 };

            int sumOfTriangleSeries = NumberDifference(numbers);
            Console.WriteLine($"The duplicate number is:{sumOfTriangleSeries}");

            int sumOfTriangleSeries1 = NumberDifference(numbers1);

            Console.WriteLine($"The duplicate number is:{sumOfTriangleSeries1}");


            int sumOfTriangleSeries2 = NumberDifference(numbers2);

            Console.WriteLine($"The duplicate number is:{sumOfTriangleSeries2}");
            Console.WriteLine("Press any key to exit");
            string a = Console.ReadLine();
        }

        static int SumOfTriangleSeries(int n)
        {
            //(((n*n) + n)/2)

             int triangleSum = ((n * n) + n) / 2;

            return triangleSum;
        }

        static int SumOfAllNumbers(int[] numbers)
        {
            int arraySum = 0;
            //sum all in array
            try
            {
                for (int i=0; i< numbers.Length; i++)
                {
                    arraySum += numbers[i];
                }
                return arraySum;
            }
            catch
            {
              return -6;

            }
        }

        static int NumberDifference(int[] numbers)
        {
            int triangleSeriesSum = SumOfTriangleSeries(numbers.Length - 1);
            int totalNumbersSum = SumOfAllNumbers(numbers);

            int difference = totalNumbersSum - triangleSeriesSum;

            return difference;
        }
    }
}
