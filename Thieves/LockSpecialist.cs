using System;
using System.Collections.Generic;
namespace Heist_part2.Thieves
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int percentageCut { get; set; }

        public LockSpecialist(string name, int skillLevel, int Percentage)
        {
            Name = name;
            SkillLevel = skillLevel;
            percentageCut = percentageCut;

        }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore--;
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine();
            }
        }

    }


}