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
            Console.WriteLine("Welcome to the ATM!"); // display only on start

            while (programIsRunning)
            {
                var getSavingsBalance = new GetSavingsBalance();
                double SavingsAccountBalance = getSavingsBalance.GetBalance();
                Console.WriteLine($"Your savings account balance is {SavingsAccountBalance}");

                var getCheckingBalance = new GetCheckingBalance();
                double CheckingAccountBalance = getCheckingBalance.GetBalance();
                Console.WriteLine($"Your checking account balance is {CheckingAccountBalance}");

                Console.WriteLine("Would you like to make a (withdrawal), (deposit) or (transfer) between your accounts?");
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
                else 
                {
                    Console.WriteLine("Please select the transfer you would like to make:");
                    Console.WriteLine("(1.) Transfer from your checking account to your savings account");
                    Console.WriteLine("(2.) Transfer from your savings account to your checking account");

                    var selection = Console.ReadLine();

                    var userTransfer = new Transfer();
                    userTransfer.StartTransfer(selection);

                    //Console.WriteLine("Your new balance is " + newAmount);
                }
               
            }
        }
    }
}


//close program functionality


//Ask to do one of the follow transactions

//transfer money from savings to checking, this should prompt the user to enter an amount to transfer, then remove that amount.This should do some basic error handler(i.e, make sure that the value inputted is a number, that the user has enough funds)
//transfer money from checking to savings, this should prompt the user to enter an amount to transfer, then remove that amount.This should do some basic error handler(i.e, make sure that the value inputted is a number, that the user has enough funds)


//object! items of different types that are relevent to each other

//the system should log all the transactions that occur to a file, these logs should have what was done, the amount that moved when it happened and what accounts were affected and other information you feel is useful


    //MULTIPLE USERS - Constructor - WHAT DOES EACH ACCT NEED???!!!