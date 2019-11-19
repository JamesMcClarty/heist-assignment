using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Heister> heisterList = new List<Heister>();

            //Bank info

            int bankDifficulty = 101;
            int teamSkillNumber = 0; 

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

                try{
                    skillLevel = int.Parse(skillString);
                }

                catch(Exception ex){

                    Console.WriteLine($"{skillString} is not a valid skill. Using the default of 10.");
                    skillLevel = 10;
                }

                Console.WriteLine("What is your courage factor?");
                courageString = Console.ReadLine();

                try{
                    courageFactor= decimal.Parse(courageString);
                }

                catch(Exception ex){

                    Console.WriteLine($"{courageString} is not a valid courage value. Using the default of 1.0.");
                    courageFactor = 1.0M;
                }
                
                Heister heister = new Heister(name, skillLevel, courageFactor);
                heisterList.Add(heister);
            }

            while(bankDifficulty > 100 || bankDifficulty < 0){
                Console.WriteLine("How difficult is the bank?");

                try {
                    bankDifficulty = int.Parse(Console.ReadLine());
                }
                catch (Exception ex){
                   Console.WriteLine("Something went wrong. Try again."); 
                }
            }

            foreach(Heister heister in heisterList){
                teamSkillNumber += heister.GetSkillLevel();
            }

            if(teamSkillNumber > bankDifficulty){
                Console.WriteLine("Well done! We're rich!"); 
            }

            else{
                Console.WriteLine("You've been caught! This wasn't part of my plans!");
            }
        }
    }
}