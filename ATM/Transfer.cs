using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Transfer
    {
        public void StartTransfer(string selection)
        {
            var newSavingsBalance = new SavingsAccount();
            var newCheckingBalance = new CheckingAccount();

            if (selection == "1")
            {
                var enterAmount = false;
                while (enterAmount == false)
                {
                    Console.WriteLine("How much would you like to transfer from your checking account to your savings account?");
                    var response = Console.ReadLine();
                    int amount;
                    bool result = Int32.TryParse(response, out amount);

                    if (result == true)
                    {
                        enterAmount = true;
                        var transactionType = "transfer";
                        newSavingsBalance.SavingsAccountBalance = newSavingsBalance.SavingsAccountBalance + amount;
                        newSavingsBalance.StoreNewTransaction(newSavingsBalance.SavingsAccountBalance);
                        newSavingsBalance.LogToStatement(newSavingsBalance.SavingsAccountBalance, amount, transactionType);

                        newCheckingBalance.CheckingAccountBalance = newCheckingBalance.CheckingAccountBalance - amount;
                        newCheckingBalance.StoreNewTransaction(newCheckingBalance.CheckingAccountBalance);
                        newCheckingBalance.LogToStatement(newCheckingBalance.CheckingAccountBalance, amount, transactionType);
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
                    Console.WriteLine("How much would you like to transfer from your savings account to your checking account?");
                    var response = Console.ReadLine();
                    int amount;
                    bool result = Int32.TryParse(response, out amount);

                    if (result == true)
                    {
                        enterAmount = true;
                        var transactionType = "transfer";
                        newCheckingBalance.CheckingAccountBalance = newCheckingBalance.CheckingAccountBalance + amount;
                        newCheckingBalance.StoreNewTransaction(newCheckingBalance.CheckingAccountBalance);
                        newCheckingBalance.LogToStatement(newCheckingBalance.CheckingAccountBalance, amount, transactionType);

                        newSavingsBalance.SavingsAccountBalance = newSavingsBalance.SavingsAccountBalance - amount;
                        newSavingsBalance.StoreNewTransaction(newSavingsBalance.SavingsAccountBalance);
                        newSavingsBalance.LogToStatement(newSavingsBalance.SavingsAccountBalance, amount, transactionType);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you didn't enter a valid amount. Please try again.");
                    }

                }
            }
        }
    }
}
