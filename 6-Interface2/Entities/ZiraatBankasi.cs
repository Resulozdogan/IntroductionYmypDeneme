using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Interface2.Entities
{
    public class ZiraatBankasi : Bank, IBankRepository
    {
        public string AddTransaction()
        {
            return "z Add Çalıştı";
        }

        public string DeleteTransaction(int id)
        {
            return "z Delete Çalıştı";
        }

        public string UpdateTransaction(int id)
        {
            return "z Update Çalıştı";
        }
    }
}
