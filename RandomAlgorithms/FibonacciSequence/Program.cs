using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //program finds the nth fibonacci sequence
            // fib n = fib(n-1)+ fib(n-2)  int maximum 2,147,483,647
            // 0,1,1,2,3,5,8,13,22  fib(1) =0, fib(2) = 1, fib3(1), fib(4)=2  1000 = 8261794739546030242  7000 = 613250440362667298
            Console.WriteLine("Hello World!");
            int n = 1000;
            var result = PrintFib(n);
            string displayMessage;
            if (result.Item2 == "01")
            {
                displayMessage = $"Index was negative. No such thing as a negative index in a series. Number counted: {result.Item3}, number iterated: {result.Item4}";
                Console.Write(displayMessage);
            }
            else
            {
                 Console.Write(result);
                displayMessage = $"The {n}th fibonacci number is {result.Item1}. Number counted: {result.Item3}, number iterated: {result.Item4}";
                Console.Write(displayMessage);
            }


        }


        static Tuple<ulong, string, int, int> PrintFib(int n)
        {
            ulong[] lastTwoNumbers = { 0, 1 };
            ulong result =0;
            string code = "01";
            int nCounted =0;
            int numberOfIterations =0;
            if (n <= 0)
            {
                nCounted = n;
                numberOfIterations++;
                return new Tuple<ulong, string, int, int>( result, code, nCounted, numberOfIterations) ;
            }
            else if (n <= 2)
            {
                 code = "00";
                nCounted = n;
                numberOfIterations++;
                result = lastTwoNumbers[n - 1];
                return new Tuple<ulong, string, int, int>(result, code, nCounted, numberOfIterations);
            }
            else
            {
                result = 1;
                for (int i = 3; i <= n; i++)
                {                    
                    result = lastTwoNumbers[0] + lastTwoNumbers[1];
                    nCounted = i;
                    numberOfIterations++;
                    lastTwoNumbers[0] = lastTwoNumbers[1];
                    lastTwoNumbers[1] = result;
                }
            }

            code = "00";
            return new Tuple<ulong, string, int, int>(result, code,  nCounted, numberOfIterations);
        }


    }
}
