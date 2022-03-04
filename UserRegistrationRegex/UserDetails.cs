using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class UserDetails
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNo { get; set; }
        public string password { get; set; }

        public void ContactDetails()
        {
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter email: ");
            email = Console.ReadLine();
            Console.Write("Enter Phone No: ");
            phoneNo = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();
        }
    }
}
