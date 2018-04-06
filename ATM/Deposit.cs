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
                        var newBalance = new SavingsAccount();
             if (accountSelection == "savings")
            {
                Console.WriteLine("How much would you like to deposit?");
                var response = Console.ReadLine();
                int amount;
                bool result = Int32.TryParse(response, out amount);

               // var enterAmount = true;
                
                //while (enterAmount)
                //{
                    if (result == true)
                    {
                        newBalance.SavingsAccountBalance = newBalance.SavingsAccountBalance + amount;
                        newBalance.StoreNewTransaction(newBalance.SavingsAccountBalance);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you didn't enter a valid amount. Please try again.");
                    }
                //}

            }

            //else 
            //{
            // add this functionality to checking
            //}

            return newBalance.SavingsAccountBalance;
            //Console.WriteLine($"Your new balance is {getSavingsBalance.SavingsAccountBalance}");


        }
    }
}
