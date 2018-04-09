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
            const string savingsAccountTransactionHistoryFilePath = "../../savingsAccountNEW.csv";
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
            const string savingsAccountTransactionHistoryFilePath = "../../savingsAccountNEW.csv";

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

        public List<string> LogToStatement(double newBalance, double amount, string transactionType)
        {
            Console.WriteLine($"{newBalance}");

            DateTime date = DateTime.Now;
            var transType = "";
            if (transactionType == "deposit")
            {
                transType = "Deposit";
            }
            else if (transactionType == "withdrawal")
            {
                transType = "Withdrawal";
            }
            else
            {
                transType = "Transfer";
            }


            var savingsAccountStatment = new List<string>();
            const string savingsAccountStatementFilePath = "../../savingsAccountStatement.csv";
            using (var reader = new StreamReader(savingsAccountStatementFilePath))
            {
                while (reader.Peek() > -1)
                {
                    var existingTransaction = reader.ReadLine();
                    savingsAccountStatment.Add(existingTransaction);
                }
            }

            var newLine = $"{date} | {transType} in Savings Account | Amount:${amount} | Balance:${newBalance}";

            savingsAccountStatment.Add(newLine);

            using (var writer = new StreamWriter(savingsAccountStatementFilePath))
            {
                foreach (var transaction in savingsAccountStatment)
                {
                    writer.WriteLine($"{transaction}");
                }
            }

            return savingsAccountStatment;
        }

        public void ViewStatement()
        {
            var savingsAccountStatment = new List<string>();
            const string savingsAccountStatementFilePath = "../../savingsAccountStatement.csv";
            using (var reader = new StreamReader(savingsAccountStatementFilePath))
            {
                while (reader.Peek() > -1)
                {
                    var existingTransaction = reader.ReadLine();
                    savingsAccountStatment.Add(existingTransaction);
                    foreach (var transaction in savingsAccountStatment)
                    {
                        Console.WriteLine($"{transaction}");
                    }
                }
            }
            
        }
    }
}
