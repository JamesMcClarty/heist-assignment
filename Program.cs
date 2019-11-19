using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crime.Net welcomes you!");

            int trialNumber = -1;
            int wins = 0;
            int losses = 0;

            //Bank info
            Random luckValue = new Random();
            int bankDifficulty = 101;
            int difficultyWithLuck = 0;
            int teamSkillNumber = 0;

            List<Heister> heisterList = new List<Heister>();

            Console.WriteLine("Crime.Net welcomes you!");

            while (heisterList.Count < 4)
            {
                string name;
                string skillString;
                string courageString;

                int skillLevel = 0;
                decimal courageFactor = 0.0M;

                Console.WriteLine($"Number of heisters: {heisterList.Count}");
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                if (name == "")
                    break;
                Console.WriteLine("What is your skill level?");
                skillString = Console.ReadLine();

                try
                {
                    skillLevel = int.Parse(skillString);
                }

                catch (Exception ex)
                {

                    Console.WriteLine($"{skillString} is not a valid skill. Using the default of 10.");
                    skillLevel = 10;
                }

                Console.WriteLine("What is your courage factor?");
                courageString = Console.ReadLine();

                try
                {
                    courageFactor = decimal.Parse(courageString);
                }

                catch (Exception ex)
                {

                    Console.WriteLine($"{courageString} is not a valid courage value. Using the default of 1.0.");
                    courageFactor = 1.0M;
                }

                Heister heister = new Heister(name, skillLevel, courageFactor);
                heisterList.Add(heister);
            }

            while (bankDifficulty > 100 || bankDifficulty < 0)
            {
                Console.WriteLine("How difficult is the bank?");

                try
                {
                    bankDifficulty = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong. Try again.");
                }
            }

            while (trialNumber <= 0)
            {
                Console.WriteLine("How many trials will you perform.");

                try
                {
                    trialNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong. Try again.");
                }

                if (trialNumber == 0)
                {
                    Console.WriteLine("Please enter a number more than 0.");
                }
            }

            foreach (Heister heister in heisterList)
            {
                teamSkillNumber += heister.GetSkillLevel();
            }

            Console.WriteLine($"The heisters' power is {teamSkillNumber} and the bank's difficulty is {bankDifficulty}");

            for (int i = 0; i < trialNumber; i++)
            {
                difficultyWithLuck = bankDifficulty + luckValue.Next(-10, 10);
                if (teamSkillNumber > difficultyWithLuck)
                {   
                    wins++;
                }
                else{
                    losses++;
                }
            }

             Console.WriteLine($"You robbed {wins} banks successfully, but you were apprehended {losses} times.");
        }
    }
}