using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
       static bool programIsRunning = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM!"); 

            while (programIsRunning)
            {
                var getSavingsBalance = new GetSavingsBalance();
                double SavingsAccountBalance = getSavingsBalance.GetBalance();
                Console.WriteLine($"Your savings account balance is {SavingsAccountBalance}");

                var getCheckingBalance = new GetCheckingBalance();
                double CheckingAccountBalance = getCheckingBalance.GetBalance();
                Console.WriteLine($"Your checking account balance is {CheckingAccountBalance}");

                Console.WriteLine("Would you like to make a (withdrawal), (deposit) or (transfer) between your accounts?");
                Console.WriteLine("You can also (view) your most recent transaction or (exit) the ATM.");
                var startTask = Console.ReadLine().ToLower();

                // ERROR HANDLING

                if (startTask == "withdrawal")
                {
                    Console.WriteLine("Do you want to withdraw from your (checking) or (savings) account?");
                    var accountSelection = Console.ReadLine().ToLower();

                    var userWithdrawal = new Withdrawal();
                    double newAmount = userWithdrawal.StartWithdrawal(accountSelection);

                    Console.WriteLine("Your new balance is " + newAmount);
                }
                else if (startTask == "deposit")
                {
                    Console.WriteLine("Do you want to deposit into your (checking) or (savings) account?");
                    var accountSelection = Console.ReadLine().ToLower();

                    var userDeposit = new Deposit();
                    double newAmount = userDeposit.StartDeposit(accountSelection);

                    Console.WriteLine("Your new balance is " + newAmount);
                }
                else if (startTask == "transfer")
                {
                    Console.WriteLine("Please select the transfer you would like to make:");
                    Console.WriteLine("(1.) Transfer from your checking account to your savings account");
                    Console.WriteLine("(2.) Transfer from your savings account to your checking account");

                    var selection = Console.ReadLine();

                    var userTransfer = new Transfer();
                    userTransfer.StartTransfer(selection);

                }
                else if (startTask == "view")
                {
                    Console.WriteLine("Do you want to view your (checking) or (savings) account?");
                    var accountSelection = Console.ReadLine().ToLower();

                    if (accountSelection == "checking")
                    {
                        var viewCheckingStatement = new CheckingAccount();
                        viewCheckingStatement.ViewStatement();
                    }
                    else
                    {
                        var viewSavingsStatement = new SavingsAccount();
                        viewSavingsStatement.ViewStatement();
                    }
                }
                else
                {
                    programIsRunning = false;
                }
               
            }
        }
    }
}


//close program functionality

    //MULTIPLE USERS - Constructor - WHAT DOES EACH ACCT NEED???!!!