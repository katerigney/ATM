using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Withdrawal
    {
        public void StartWithdrawal()
        {
            Console.WriteLine("Do you want to withdrawal from your (checking) or (savings) account?");
            var accountSelection = Console.ReadLine().ToLower();
            if (accountSelection == "savings")
            {
                var userSavings = new SavingsAccount();
                userSavings.CheckAccountBalance();
            }




        }



    }
}
