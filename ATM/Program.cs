using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
       static public void MMenu()
        {
            Console.WriteLine("Would you like to make a (withdrawal), (deposit) or (transfer)? You can also (view) your account balance.");
            var startTask = Console.ReadLine().ToLower();
            if (startTask == "withdrawal")
            {
                var userWithdrawal = new Withdrawal();
                userWithdrawal.StartWithdrawal();
            }
            else if (startTask == "deposit")
            {
                Console.WriteLine("Do you want to deposit into your (checking) or (savings) account?");
                var accountSelection = Console.ReadLine().ToLower();
        
                var userDeposit = new Deposit();
                userDeposit.StartDeposit(accountSelection);

            }
            else if (startTask == "transfer")
            {
                //transfer functionality

            }
            else
            {
                //view functionality
            }
        }

        static public void ReturnCurrentBalance(/*program name, balance*/ )
        {
            var currentAccount = new SavingsAccount();

            Console.WriteLine($"Your {//AcctType} Account Balance is ${currentBalance.SavingsAccountBalance}. Would you like to make another transaction? (Yes) or (No)");
            var response = Console.ReadLine().ToLower();
            if (response == "Yes")
            {
                MMenu();
            }
            else
            {
                Main.programIsRunning = false;
            }
        }

        //FUNCTION: return current balance / Make another transaction?
        //FUNCTION: determine which account to adjust (CHECKING OR SAVINGS)

        static void Main(string[] args)
        {
            //the system assumes only 1 user

            var programIsRunning = true;

            while (programIsRunning)
            {
                //when the program starts, it will display the current balance for their checking and savings account.If none exist, show 0.
                Console.WriteLine("Welcome to the ATM!"); // display only on start
          
                MMenu();
            }
        }
    }
}




//Ask to do one of the follow transactions
// withdraw from savings, this should prompt the user to enter an amount to withdraw, then remove that amount. This should do some basic error handler (i.e, make sure that the value inputted is a number, that the user has enough funds)
//withdraw from checking, this should prompt the user to enter an amount to withdraw, then remove that amount. This should do some basic error handler(i.e, make sure that the value inputted is a number, that the user has enough funds)
//deposit to savings , this should prompt the user to add a an amount to this account, then add that amount. 
//deposit to checking, this should prompt the user to add a an amount to this account, then add that amount. This should do some basic error handler(i.e, make sure that the value inputted is a number)
//transfer money from savings to checking, this should prompt the user to enter an amount to transfer, then remove that amount.This should do some basic error handler(i.e, make sure that the value inputted is a number, that the user has enough funds)
//transfer money from checking to savings, this should prompt the user to enter an amount to transfer, then remove that amount.This should do some basic error handler(i.e, make sure that the value inputted is a number, that the user has enough funds)

//the system should save the new amount to a file after every action

//object! items of different types that are relevent to each other

//the system should log all the transactions that occur to a file, these logs should have what was done, the amount that moved when it happened and what accounts were affected and other information you feel is useful


    //MULTIPLE USERS - Constructor - WHAT DOES EACH ACCT NEED???!!!