using System;
using System.Collections.Generic;
namespace Heist_part2.Thieves
{


    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int percentageCut { get; set; }
        public Hacker(string name, int skillLevel, int Percentage)
        {
            Name = name;
            SkillLevel = skillLevel;
            percentageCut = percentageCut;

        }


        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore--;
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system");
            }
        }
    }

}