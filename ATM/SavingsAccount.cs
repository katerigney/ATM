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


        //public void CheckAccountBalance()
        //{

            //var currentSavingsAccountBalance = new List<>;

           // const string savingsAccountFilePath = "../../savingsAccount.csv";

           // using (var reader = new StreamReader(savingsAccountFilePath))
          //  {
           //     while (reader.Peek() > -1)
           //     {
              //      var existingTransaction = Convert.ToInt32(reader.ReadLine());

              //      SavingsAccountBalance.Add(existingTransaction);
             //   }
          //  }


          //  Console.WriteLine($"S{SavingsAccountBalance}");
          //  Console.ReadLine();            
        //}

        public void StoreNewTransaction(double newTransaction)
        {
            var userData = new List<string>();
            const string savingsAccountFilePath = "../../savingsAccount.csv";

            userData.Add(newTransaction.ToString());

            using (var writer = new StreamWriter(savingsAccountFilePath))
            {
                foreach (var transaction in userData) { 
                Console.WriteLine("storing user data");
                writer.WriteLine($"{transaction}");
                }
            }

        }




    }
}

//will need to convert $$ values to strings

