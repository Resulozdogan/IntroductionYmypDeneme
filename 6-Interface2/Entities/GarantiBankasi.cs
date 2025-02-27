using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Interface2.Entities
{
    public class GarantiBankasi :Bank, IBankRepository
    {
        public string AddTransaction()
        {
            return "g Add Çalıştı";
        }

        public string DeleteTransaction(int id)
        {
            return "g Delete Çalıştı";
        }

        public string UpdateTransaction(int id)
        {
            return "g Update Çalıştı";
        }
    }
}
