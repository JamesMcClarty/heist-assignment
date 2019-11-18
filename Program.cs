using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Heister> heisterList = new List<Heister>();

            Console.WriteLine("Crime.Net welcomes you!");

            while (heisterList.Count < 4)
            {
                string name;
                int skill;
                decimal courage;
                Console.WriteLine($"Number of heisters: {heisterList.Count}");
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                if (name == "")
                    break;
                Console.WriteLine("What is your skill level?");
                skill = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your courage factor?");
                courage = decimal.Parse(Console.ReadLine());
                Heister heister = new Heister(name, skill, courage);
                heisterList.Add(heister);
            }

            foreach(Heister heister in heisterList){
                heister.Display();
            }

        }
    }
}