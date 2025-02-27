using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOPTemelPrensipler1.Entities
{
    public class Customer
    {
        public Customer()
        {
            //.........
        }

        public string? CustomerID { get; } = Guid.NewGuid().ToString();
        public string? EmailAdress { get; set; }
        public string? Country { get; set; }
        public string? CompanyName { get; set; }
        public bool IsActive { get; set; }
    }
}
