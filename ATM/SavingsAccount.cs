using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATM
{
    class SavingsAccount
    {
        public double SavingsAccountBalance { get; set; }

        public List<string> CheckAccountBalance()
        { 
            var currentSavingsAccountBalance = new List<string>();

            const string savingsAccountFilePath = "../../savingsAccount.csv";

            using (var reader = new StreamReader(savingsAccountFilePath))
            {
                while (reader.Peek() > -1)
                {
                    var existingTransaction = reader.ReadLine();

                    currentSavingsAccountBalance.Add(existingTransaction);
                }
            }
            return currentSavingsAccountBalance;
        }


        public void StoreNewTransaction(double newTransaction)
        {
            var newUserData = new List<string>();
            const string savingsAccountFilePath = "../../savingsAccount.csv";
            newUserData = CheckAccountBalance();//need to Split the List and convert to integers and add

            // SavingsAccountBalance = SavingsAccountBalance + newUserData;


            newUserData.Add(newTransaction.ToString());

            using (var writer = new StreamWriter(savingsAccountFilePath))
            {
                foreach (var transaction in newUserData)
                {
                    Console.WriteLine("storing user data");
                    writer.WriteLine($"{transaction}");
                }
            }
            Console.WriteLine($"Your Savings Account Balance is ${SavingsAccountBalance}");
        }




    }
}
