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

        public void CheckAccountBalance()
        {
            var CurrentAccountBalance = new List<string>();

            const string savingsAccountFilePath = "../../savingsAccount.csv";

            using (var reader = new StreamReader(savingsAccountFilePath))
            {
                while (reader.Peek() > -1)
                {
                    var existingTransaction = reader.ReadLine();
                    
                    AccountBalance.Add(existingTransaction);
                }
            }


            Console.WriteLine($"S{AccountBalance.Count}");
            Console.ReadLine();            
        }




    }
}

//will need to convert $$ values to strings

