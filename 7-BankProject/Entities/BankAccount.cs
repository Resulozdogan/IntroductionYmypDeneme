using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _7_BankProject.Entities
{
    public class BankAccount(string nameSurname, decimal firstBalance)
    {
        public string? Number { get; } = Guid.NewGuid().ToString();
        public string? Owner { get; set; } = nameSurname;
        public decimal Balance 
        { 
            get 
            {
                decimal b = 0;
                foreach (var item in AllTransactions)
                {
                    b += item.Amount;
                }
                return b;
            }
        } 
        public List<Transaction> AllTransactions { get; set; }
    }
}
