using System;
using System.Collections.Generic;
using Heist_part2.Thieves;

namespace Heist_part2
{
    class program
    {

        static void Main(string[] args)
        {
            Hacker Sam = new Hacker("sam", 10, 20);

            Muscle Joe = new Muscle("Joe", 11, 15);

            LockSpecialist Bob = new LockSpecialist("Bob", 12, 22);


            List<IRobber> rolodex = new List<IRobber>
            {
                Sam,Joe,Bob
            };
            Random r = new Random();

            Bank bank = new Bank(r.Next(50_00, 1_000_000), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), true);



            AddCrewMember();
            void AddCrewMember()
            {
                Console.WriteLine($"Current Heist operatives{rolodex.Count}");
                Console.WriteLine($"pick a crew member: ");
                var NewCrewMember = Console.ReadLine();
                while (NewCrewMember != "")
                {
                    Console.WriteLine($"{NewCrewMember}");
                    Console.WriteLine($"{NewCrewMember} can be 1 -Hacker(Disable Alarm),2 -Muscle(Disarm Guard) 3 -LockSpecialist(cracks vault");
                    var thief = int.Parse(Console.ReadLine());
                    string[] thiefTypes = new string[] { "Null", "Hacker", "Muscle", "LockSpecialist" };
                    var thiefType = thiefTypes[thief];
                    Console.WriteLine($"{NewCrewMember} is a {thiefTypes}");
                    Console.WriteLine($"what will {NewCrewMember} 's skill level be? (1-100)");
                    var skillLevel = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"{NewCrewMember} has a skilllevel of {skillLevel}");
                    Console.WriteLine($"what percentage cut does{NewCrewMember} want to recieve");
                    var percentageCut = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"{NewCrewMember} has a skilllevel of {percentageCut} % of heist earnings");
                    if (thief == 1)
                    {
                        rolodex.Add(new Hacker(NewCrewMember, skillLevel, percentageCut));
                    }
                    else if (thief == 2)
                    {
                        rolodex.Add(new Muscle(NewCrewMember, skillLevel, percentageCut));
                    }
                    else
                    {
                        rolodex.Add(new LockSpecialist(NewCrewMember, skillLevel, percentageCut));
                    }
                    Console.WriteLine("add other crew member? (Y/N):");
                    var answer = Console.ReadLine().ToLower();
                    if (answer == "Y")
                    {
                        AddCrewMember();
                    }
                    Console.WriteLine($"the most secure system is the {bank.MostSecure()},and the least secure system is the {bank.LeastSecure()} ");
                }
                foreach (IRobber thief in rolodex)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
