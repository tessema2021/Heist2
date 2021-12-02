using System;
using System.Collections.Generic;
namespace Heist_part2.Thieves
{

    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int percentageCut { get; set; }
        public Muscle(string name, int skillLevel, int Percentage)
        {
            Name = name;
            SkillLevel = skillLevel;
            percentageCut = percentageCut;

        }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore--;
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has Knocked out the Security Guard");
            }
            else
            {
                Console.WriteLine($"{Name} is fighting Security ,DecreasedSecurity health by {SkillLevel}");
            }
        }
    }

}