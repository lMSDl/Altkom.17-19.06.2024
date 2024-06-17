using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }
        public bool IsDeleted { get; }

        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }

        public PaymentAccount PaymentAccount { get; } = new PaymentAccount();
    }
}
