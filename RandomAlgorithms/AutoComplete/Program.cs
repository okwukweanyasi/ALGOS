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
            string searchword = "de";
            Dictionary<string, string> result = FindWords(searchword, wordsRepository);
            Console.WriteLine($"result: {result}");
            foreach (var res in result)
            {
                Console.WriteLine("Search Word {0}: returned Words = {1}", res.Key, res.Value);
            }

            var result1 = FindWordsOptimized(searchword, wordsRepository);
            foreach (var res in result1)
            {                
                Console.WriteLine("Search Word {0}: returned Words = {", res.Key);
                foreach (var r in res.Value)
                {
                    Console.Write("[Key {0}: Value{1}]", r.Key, r.Value);
                }
            }
            Console.WriteLine("Press any key to exit");
            string a = Console.ReadLine();
        }

        public static Dictionary<string, Dictionary<string,string>> FindWordsOptimized(string inputString, List<string> repo)
        {
           
            int inputLenght = inputString.Length;

            foreach (string r in repo)
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

            return matchedWordsDictPair;
        }
        public static Dictionary<string,string> FindWords(string inputString, List<string> repo)
        {
            Dictionary<string, string> matchedWords = new Dictionary<string, string>();
            int inputLenght = inputString.Length;
            
            foreach (string r in repo)
            {
                string prefixWord = r.Substring(0, inputLenght);
                if (string.Equals(prefixWord, inputString, StringComparison.OrdinalIgnoreCase))
                {
                    matchedWords.Add(r, r);
                }
            }

            return matchedWords;
        }
    }
}
