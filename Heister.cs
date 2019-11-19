using System;

namespace heist{

    public class Heister{

        public Heister(string _name, int _skillLevel, decimal _courageFactor){
            name = _name;
            skillLevel = _skillLevel;
            courageFactor = _courageFactor;
        }

        private string name;
        private int skillLevel;
        private decimal courageFactor;

        public void Display(){
            Console.WriteLine($"Name: {name} Skill Level: {skillLevel} Courage Factor: {courageFactor}");
        }

        public int GetSkillLevel(){
            return skillLevel;
        }
        
    }
}