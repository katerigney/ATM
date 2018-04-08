using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ATM
{
    class GetSavingsBalance
    {
        public double SavingsAccountBalance { get; set; }

        public double GetBalance()
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
            return SavingsAccountBalance;
        }
    }
}
