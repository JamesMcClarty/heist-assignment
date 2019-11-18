using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crime.Net welcomes you!");

            string name;
            int skill;
            decimal courage;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your skill level?");
            skill = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your courage factor?");
            courage = decimal.Parse(Console.ReadLine());

            Heister heister1 = new Heister (name, skill, courage);
            heister1.Display();
        }
    }
}
