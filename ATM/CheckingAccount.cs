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

        public List<string> LogToStatement(double newBalance, double amount, string transactionType)
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

            var newLine = $"{date} | {transType} in Savings Account | Amount:${amount} | Balance:${newBalance}";

            checkingAccountStatment.Add(newLine);

            using (var writer = new StreamWriter(checkingAccountStatementFilePath))
            {
                foreach (var transaction in checkingAccountStatment)
                {
                    writer.WriteLine($"{transaction}");
                }
            }

            return checkingAccountStatment;
        }

        public void ViewStatement()
        {
            var checkingAccountStatment = new List<string>();
            const string checkingAccountStatementFilePath = "../../savingsAccountStatement.csv";
            using (var reader = new StreamReader(checkingAccountStatementFilePath))
            {
                while (reader.Peek() > -1)
                {
                    var existingTransaction = reader.ReadLine();
                    checkingAccountStatment.Add(existingTransaction);
                }
            }
            foreach (var transaction in checkingAccountStatment)
            {
                Console.WriteLine($"{transaction}");
            }
        }
    }
}