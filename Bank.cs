using System;
namespace Heist_part2
{


    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure { get; } = false;
        public Bank(int cashOnHand, int alarmScore, int vaultScore, int securityGuardScore, bool isSecure)
        {
            CashOnHand = cashOnHand;
            AlarmScore = alarmScore;
            VaultScore = vaultScore;
            SecurityGuardScore = securityGuardScore;
            IsSecure = isSecure;

        }
        public string MostSecure()
        {
            if (SecurityGuardScore < VaultScore && VaultScore > AlarmScore)
            {
                return "vault Score";
            }
            else if (SecurityGuardScore < AlarmScore && AlarmScore > VaultScore)
            {
                return "Alarm Score";
            }
            else { return "security gaurd score"; }
        }
        public string LeastSecure()
        {
            if (SecurityGuardScore > VaultScore && VaultScore < AlarmScore)
            {
                return "vault ";
            }
            else if (SecurityGuardScore > AlarmScore && AlarmScore < VaultScore)
            {
                return "Alarm Score";
            }
            else { return "security gaurd score"; }
        }
    }
}