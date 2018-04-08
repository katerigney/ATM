using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ATM
{
    class CheckingAccount
    {
        public double CheckingAccountBalance { get; set; }

        public List<string> CheckAccountBalance()
        {
            var checkingAccountTransactionHistory = new List<string>();
            const string checkingAccountTransactionHistoryFilePath = "../../checkingAccountNEW.csv";
            using (var reader = new StreamReader(checkingAccountTransactionHistoryFilePath))
            {
                while (reader.Peek() > -1)
                {
                    var existingTransaction = Convert.ToInt32(reader.ReadLine());
                    CheckingAccountBalance = CheckingAccountBalance + existingTransaction;
                    var existingTransactionReWrite = Convert.ToString(existingTransaction);
                    checkingAccountTransactionHistory.Add(existingTransactionReWrite);
                }
            }
            return checkingAccountTransactionHistory;
        }

        public double StoreNewTransaction(double newTransaction)
        {
            var newTransactionHistory = new List<string>();
            const string checkingAccountTransactionHistoryFilePath = "../../checkingAccountNEW.csv";
       
            newTransactionHistory = CheckAccountBalance();
            newTransactionHistory.Add(newTransaction.ToString());
            using (var writer = new StreamWriter(checkingAccountTransactionHistoryFilePath))
            {
                foreach (var transaction in newTransactionHistory)
                {
                    writer.WriteLine($"{transaction}");
                }
            }

            return CheckingAccountBalance;

        }

        public List<string> LogToStatement(double newTransaction, string transactionType)
        {
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

            var checkingAccountStatment = new List<string>();
            const string checkingAccountStatementFilePath = "../../checkingAccountStatement.csv";
            using (var reader = new StreamReader(checkingAccountStatementFilePath))
            {
                while (reader.Peek() > -1)
                {
                    var existingTransaction = reader.ReadLine();
                    checkingAccountStatment.Add(existingTransaction);
                }
            }

            var newTransactionHistory = new List<string>();
            newTransactionHistory.Add(newTransaction.ToString());
            using (var writer = new StreamWriter(checkingAccountStatementFilePath))
            {
                foreach (var transaction in newTransactionHistory)
                {
                    writer.WriteLine($"{date} | {transType} in Savings Account | Amount:{transaction}");
                }
            }

            return checkingAccountStatment;
        }
    }
}
