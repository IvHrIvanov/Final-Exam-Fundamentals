using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
           
            string[] commandsArgs = Console.ReadLine().Split();

            while (commandsArgs[0] != "Complete")
            {
                string command = commandsArgs[0];

                if (command == "Make")
                {
                    if (commandsArgs[1] == "Upper")
                    {
                        input = input.ToUpper();
                        Console.WriteLine(input);
                    }
                    else if (commandsArgs[1] == "Lower")
                    {
                        input = input.ToLower();
                        Console.WriteLine(input);
                    }
                }
                else if (command == "GetDomain")
                {
                    int count = int.Parse(commandsArgs[1]);
                    string print = input.Substring(input.Length-count);
                    Console.WriteLine(print);
                }
                else if(command=="GetUsername")
                {
                    int index = input.IndexOf("@");
                    if(input.Contains("@"))
                    {
                        string print = input.Substring(0,index);
                        Console.WriteLine(print);
                    }
                    else
                    {
                        Console.WriteLine($"The email {input} doesn't contain the @ symbol.");
                    }
                }
                else if(command=="Replace")
                {
                    string oldChar = commandsArgs[1];
                    string newChar = "-";
                    input = input.Replace(oldChar,newChar);
                    Console.WriteLine(input);
                }
                else if(command=="Encrypt")
                {
                    List<int> encrypt = new List<int>(); 
                    foreach (var item in input)
                    {
                       
                            int number = (int)item;
                            encrypt.Add(number);
                        
                    }
                    Console.WriteLine(string.Join(" ", encrypt));
                }

                    commandsArgs = Console.ReadLine().Split();
            }
        }
    }
}