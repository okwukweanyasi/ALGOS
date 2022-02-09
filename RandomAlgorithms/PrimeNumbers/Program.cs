using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(49 % 2);
            List<int> input = new List<int> { 49, 1, 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 25, 81 };
            Console.WriteLine(String.Join(",", PrimeNumbers(input)));

        }

		public static List<int> PrimeNumbers(List<int> inputNumbers)
		{
			int inputLenght = inputNumbers.Count;
			List<int> foundPrimes = new List<int>();

			for (int i = 0; i < inputLenght; i++)
			{
				//int divisorCount =0;
				if (inputNumbers[i] < 2)
				{
					//skip continue
				}

				else if (inputNumbers[i] == 2 || inputNumbers[i] == 3)
				{
					foundPrimes.Add(inputNumbers[i]);
				}
				else if (inputNumbers[i] % 2 != 0 && inputNumbers[i] % 3 != 0)
				{
					int count = 0;
					for (int j = 5; j < inputNumbers[i]; j++)
					{
						if (inputNumbers[i] % j == 0)
						{
							count++;
						}
					}
					if (count == 0)
					{
						foundPrimes.Add(inputNumbers[i]);

					}
				}
			}
			return foundPrimes;

		}


	}
}
