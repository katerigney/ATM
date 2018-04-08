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
            var savingsAccountTransactionHistory = new List<string>();
            const string savingsAccountTransactionHistoryFilePath = "../../savingsAccount.csv";
            using (var reader = new StreamReader(savingsAccountTransactionHistoryFilePath))
            {
                while (reader.Peek() > -1)
                {
                    var existingTransaction = Convert.ToInt32(reader.ReadLine());
                    SavingsAccountBalance = SavingsAccountBalance + existingTransaction;
                    var existingTransactionReWrite = Convert.ToString(existingTransaction);
                    savingsAccountTransactionHistory.Add(existingTransactionReWrite);
                }
            }
            return savingsAccountTransactionHistory;
        }

        public double StoreNewTransaction(double newTransaction)
        {
            var newTransactionHistory = new List<string>();
            const string savingsAccountTransactionHistoryFilePath = "../../savingsAccount.csv";
            newTransactionHistory = CheckAccountBalance();
            newTransactionHistory.Add(newTransaction.ToString());
            using (var writer = new StreamWriter(savingsAccountTransactionHistoryFilePath))
            {
                foreach (var transaction in newTransactionHistory)
                {
                    writer.WriteLine($"{transaction}");
                }
            }

            return SavingsAccountBalance;

        }
    }
}
