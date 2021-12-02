using System;
namespace Heist_part2.Thieves
{

    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int percentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {

        }
    }

}