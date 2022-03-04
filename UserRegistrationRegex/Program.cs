using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UserDetails userdetails = new UserDetails();
            //userdetails.ContactDetails();
            User_Registration_Regex user_Registration_Regex = new User_Registration_Regex();
            Console.WriteLine(user_Registration_Regex.ValidateMobileNo("7206594149"));
        }
    }
}
