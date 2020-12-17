using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Final_Exam_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(!)?(?<command>[A-Z][a-z]{2,})\1:\[(?<colon>[A-z]{8,})\]";

            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection match = regex.Matches(input);
                if (match.Count > 0)
                {
                    string command = match[0].Groups[2].Value;
                    List<int> asci = new List<int>();
                    int number = 0;
                    foreach (Match item in match)
                    {

                        foreach (var current in item.Groups[3].Value)
                        {
                            number = (int)current;
                            asci.Add(number);
                        }
                    }
                    Console.WriteLine($"{command}: {string.Join(" ",asci)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}