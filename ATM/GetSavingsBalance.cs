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
            Console.WriteLine("SavingsAccountBalance{}");
            return SavingsAccountBalance;
        }
    }
}
