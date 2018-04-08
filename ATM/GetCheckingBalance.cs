using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATM
{
    class GetCheckingBalance
    {
        public double CheckingAccountBalance { get; set; }

        public double GetBalance()
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
            return CheckingAccountBalance;
        }
    }
}
