using System;
using System.Collections;

namespace QueueAndStacks
{
    class Program
    {
        public static int stack1Count = 0;
        public static Stack stack1 = new Stack();
         public static Stack stack2 = new Stack();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] items = {"1","2","3","4","5"};


            foreach (var i in items)
            {

                stack1.Push(i);
                stack1Count++;

            }

            // Displays the Queue.
            Console.Write("Stack 1 values:");
            PrintValues(stack1);

            for (int i = 0; i < stack1Count; i++)
            {

                stack2.Push(stack1.Pop());

            }

            // Displays the Queue.
            Console.Write("Stack 2 values:");
            PrintValues(stack2);


        }



        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
