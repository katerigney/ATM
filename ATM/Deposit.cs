using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Deposit
    {
        public double StartDeposit(string accountSelection)
        {
            var newSavingsBalance = new SavingsAccount();
            //var newCheckingBalance = new CheckingAccount();


            if (accountSelection == "savings")
            {
                Console.WriteLine("How much would you like to deposit?");
                var response = Console.ReadLine();
                int amount;
                bool result = Int32.TryParse(response, out amount);

                var enterAmount = true;

                while (enterAmount)
                {
                    if (result == true)
                    {
                        newSavingsBalance.SavingsAccountBalance = newSavingsBalance.SavingsAccountBalance + amount;
                        newSavingsBalance.StoreNewTransaction(newSavingsBalance.SavingsAccountBalance);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you didn't enter a valid amount. Please try again.");
                    }
                }

            }

            /*else
            {
                Console.WriteLine("How much would you like to deposit?");
                var response = Console.ReadLine();
                int amount;
                bool result = Int32.TryParse(response, out amount);

                var enterAmount = true;

                while (enterAmount)
                {
                    if (result == true)
                    {
                        newCheckingBalance.CheckingAccountBalance = newCheckingBalance.CheckingAccountBalance + amount;
                        newCheckingBalance.StoreNewTransaction(newCheckingBalance.CheckingAccountBalance);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you didn't enter a valid amount. Please try again.");
                    }
                }
            }*/

            return newSavingsBalance.SavingsAccountBalance;
            //return newCheckingBalance.CheckingAccountBalance;



        }
    }
}
