using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.logic
{
    public class Transaction
    {
        public string AccountNumber { get; set; }
        
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Amount { get; set; }

        public Transaction(string description, decimal amount, string accountNumber, DateTime  timeStamp)
        {
            
            AccountNumber = accountNumber ;
            Description = description;
            Timestamp = timeStamp ;
            Amount = amount;
            
        }
        


    }
}
