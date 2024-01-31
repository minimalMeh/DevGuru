using DevGuru.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevGuru.Console
{
    public static class Runner
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("GOF PATTERNS CONSOLE APP");

            PrintInformation();

            while (true)
            {
                var inputString = System.Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(inputString))
                    continue;

                if (inputString == "/q")
                    break;

                if (inputString == "/c")
                {
                    System.Console.Clear();
                    continue;
                }

                if (inputString == "/h")
                {
                    PrintInformation();
                    continue;
                }

                try
                {
                    IPattern pattern = PatternsCollection.GetPatternByAlias(inputString);
                    pattern.Run();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }

        private static void PrintInformation()
        {
            System.Console.WriteLine("--------- INFO ----------");
            System.Console.WriteLine("/q - exit");
            System.Console.WriteLine("/c - clean console");
            System.Console.WriteLine("/h - help");
            System.Console.WriteLine("-------------------------");

            System.Console.WriteLine("Enter one of the patterns aliases:");
            List<string> patternsInstructions = PatternsCollection.PatternAliases.Select(p => $"{p.Key} - [{string.Join(", ", p.Value)}]").ToList();
            patternsInstructions.ForEach(System.Console.WriteLine);
            System.Console.WriteLine("-------------------------");
        }
    }
}
