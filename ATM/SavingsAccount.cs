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
        public double SavingsAccountBalance { get; set; } = 0;

        public List<string> CheckAccountBalance()
        { 
            var savingsAccountDepositHistory = new List<string>();
            const string savingsAccountDepositHistoryFilePath = "../../savingsAccount.csv";
            using (var reader = new StreamReader(savingsAccountDepositHistoryFilePath))
            {
                while (reader.Peek() > -1)
                {
                    var existingDeposit = Convert.ToInt32(reader.ReadLine());
                    SavingsAccountBalance = SavingsAccountBalance + existingDeposit;
                    var existingDepositReWrite = Convert.ToString(existingDeposit);
                    savingsAccountDepositHistory.Add(existingDepositReWrite);
                }
            }
            return savingsAccountDepositHistory;
        }

        public void StoreNewTransaction(double newTransaction)
        {
            var newDepositHistory = new List<string>();
            const string savingsAccountDepositHistoryFilePath = "../../savingsAccount.csv";
            newDepositHistory = CheckAccountBalance();
            newDepositHistory.Add(newTransaction.ToString());
            using (var writer = new StreamWriter(savingsAccountDepositHistoryFilePath))
            {
                foreach (var transaction in newDepositHistory)
                {
                    writer.WriteLine($"{transaction}");
                }
            }

        }
    }
}
