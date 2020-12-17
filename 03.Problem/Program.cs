using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            string[] commands = Console.ReadLine().Split("->");

            while (commands[0] != "Statistics")
            {
                string curComand = commands[0];
                string userName = commands[1];

                if (curComand == "Add")
                {
                    if (!users.ContainsKey(userName))
                    {
                        users.Add(userName,new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{userName} is already registeres");
                    }
                }
                else if(curComand=="Send")
                {
                    string email = commands[2];
                    users[userName].Add(email);
                }
                else if(curComand=="Delete")
                {
                    if(users.ContainsKey(userName))
                    {
                        users.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} not found!");
                    }
                }
                
                commands = Console.ReadLine().Split("->");
            }
            Console.WriteLine($"Users count: {users.Keys.Count}");
          
            foreach (var item in users.OrderByDescending(x=>x.Value.Count).ThenBy(a=>a.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var text in item.Value)
                {
                    Console.WriteLine($" - {text.Value}");
                }

            }
        }
    }

}
