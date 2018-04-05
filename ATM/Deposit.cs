using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Deposit
    {
        public void StartDeposit()
        {
            Console.WriteLine("Do you want to deposit into your (checking) or (savings) account?");
            var accountSelection = Console.ReadLine().ToLower();

            if (accountSelection == "savings")
            {
                var userSavingsCurrentBalance = new SavingsAccount();
                userSavingsCurrentBalance.CheckAccountBalance();

                Console.WriteLine("How much would you like to deposit?");
                var amount = Convert.ToInt32(Console.ReadLine());
                var newBalance = new SavingsAccount();
                newBalance.SavingsAccountBalance = newBalance.SavingsAccountBalance + amount;
                Console.WriteLine($"Your Savings Account Balance is ${newBalance.SavingsAccountBalance}");
                Console.ReadLine();
            }

            //else 
            //{
            // add this functionality to checking
            //}




        }
    }
}
