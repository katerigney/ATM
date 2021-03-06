﻿using System;
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
            var newCheckingBalance = new CheckingAccount();
            double updatedBalance = 0;

            if (accountSelection == "savings")
            {
                var enterAmount = false;
                while (enterAmount == false)
                {

                    Console.WriteLine("How much would you like to deposit?");
                    var response = Console.ReadLine();
                    int amount;
                    bool result = Int32.TryParse(response, out amount);

                    if (result == true)
                    {
                        enterAmount = true;
                        var transactionType = "deposit";
                        newSavingsBalance.SavingsAccountBalance = newSavingsBalance.SavingsAccountBalance + amount;
                        newSavingsBalance.StoreNewTransaction(newSavingsBalance.SavingsAccountBalance);
                        newSavingsBalance.LogToStatement(newSavingsBalance.SavingsAccountBalance, amount, transactionType);
                        updatedBalance = newSavingsBalance.SavingsAccountBalance;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you didn't enter a valid amount. Please try again.");
                    }

                }

            }

            else
            {
                var enterAmount = false;
                while (enterAmount == false)
                {
                    Console.WriteLine("How much would you like to deposit?");
                    var response = Console.ReadLine();
                    int amount;
                    bool result = Int32.TryParse(response, out amount);

                    if (result == true)
                    {
                        enterAmount = true;
                        var transactionType = "deposit";
                        newCheckingBalance.CheckingAccountBalance = newCheckingBalance.CheckingAccountBalance + amount;
                        newCheckingBalance.StoreNewTransaction(newCheckingBalance.CheckingAccountBalance);
                        newCheckingBalance.LogToStatement(newCheckingBalance.CheckingAccountBalance, amount, transactionType);
                        updatedBalance = newCheckingBalance.CheckingAccountBalance;

                    }
                    else
                    {
                        Console.WriteLine("Sorry, you didn't enter a valid amount. Please try again.");
                    }
                }
            }
            return updatedBalance;
        }
    }
}
