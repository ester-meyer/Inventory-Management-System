using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Customer
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsClubCustomer {  get; set; }
        public Customer(int id, string name, string adderss, string phoneNumber)
        {
            Id = id;
            IsClubCustomer = false;
        }
        public Customer() { }

        public override string ToString()
        {
            return string.Format("id=", Id, " name=", Name, " address=", Address, " phone-number=", PhoneNumber);
        }
    }
}
