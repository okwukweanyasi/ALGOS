using System;

namespace RandomAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //string[] words = new string[] { "W", " o", "r", "d" };
            char words ="Word";

            //            def rec(value):
            //    if value == 0:
            //        return 1
            //    return rec(value - 1) * value
            //print(rec(3))
            int permutationsSize = 1;
            for(int i = 0; i < words.Length; i++){
                permutationsSize = permutationsSize * (i+1);
            }
            int[] permutatedWords = new int[permutationsSize];

            int currentIterationSize = words.Length;
            for(int i = 0; i < words.Length; i++){

            }

        }



        string[] BaseFActorial(string first, string second)
        {
            string[] result = new string[2];
            result[0] = $"{ first}{ second}";
            result[1] = $"{ second}{ first}";

            return result;
        }

    }
}
