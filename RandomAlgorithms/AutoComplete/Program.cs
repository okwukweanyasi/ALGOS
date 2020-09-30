using System;
using System.Collections.Generic;

namespace AutoComplete
{
    class Program
    {
        static Dictionary<string, Dictionary<string, string>> matchedWordsDictPair = new Dictionary<string, Dictionary<string, string>>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> wordsRepository = new List<string> { "dog", "deer", "deal", "deer","doggy", "fiasco", "fiachetto" };
            Console.WriteLine("Do you want to search for a word? Press 'Y' to continue with search and 'N' to exit");
            string decision = Console.ReadLine();
            while (!(decision.ToLower() == "y" ||decision.ToLower() == "n"))
            {
                Console.WriteLine("Do you want to search for a word? Press 'Y' to continue with search and 'N' to exit");
                decision = Console.ReadLine();

            }
            while (decision.ToLower() == "y")
            {
                Console.WriteLine("Enter search word");
                string searchword = Console.ReadLine();
                var result1 = FindWordsOptimized(searchword, wordsRepository);
                foreach (var res in result1)
                {
                    Console.WriteLine($"Search Word {res.Key}: returned Words =");
                    Console.Write("{");
                    foreach (var r in res.Value)
                    {
                        Console.Write("[Key: {0}, Value: {1}] ;", r.Key, r.Value);
                    }
                    Console.WriteLine("}");
                }
                Console.WriteLine("Do you want to search for another  word? Press 'Y' to continue with search and 'N' to exit");
                decision = Console.ReadLine();
            }
           
        }

        public static Dictionary<string, Dictionary<string,string>> FindWordsOptimized(string inputString, List<string> repo)
        {
           
            int inputLenght = inputString.Length;

            foreach (string r in repo)
            {
                if (r.Length > inputLenght)
                {
                    string prefixWord = r.Substring(0, inputLenght);
                    if (string.Equals(prefixWord, inputString, StringComparison.OrdinalIgnoreCase))
                    {
                        if (matchedWordsDictPair.ContainsKey(inputString))
                        {
                            Dictionary<string, string> matchwordArray = matchedWordsDictPair[inputString];
                            if (!matchwordArray.ContainsKey(r))
                            {
                                matchwordArray.Add(r, r);
                            }
                        }
                        else
                        {
                            Dictionary<string, string> matchwordArray = new Dictionary<string, string>();
                            matchwordArray.Add(r, r);
                            matchedWordsDictPair.Add(inputString, matchwordArray);
                        }
                    }

                }
            }

            return matchedWordsDictPair;
        }
  
    }
}
