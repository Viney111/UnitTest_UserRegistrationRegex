using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class User_Registration_Regex
    {
        public static string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string eMailRegex = @"^[a-z]{3,}([.]{1}[a-z]{2,})?@bl.co([.]{1}[a-z]{2})?$";
        public static string mobileNoFormat = @"^91[ ][5-9]{1}[0-9]{9}$";
        public static string passwordFormat = "^(?=.*[!@#$%^&*])(?=.*[A-Z])(?=.*[0-9])[a-zA-Z1-9]{1}[a-zA-Z0-9]{7,}";
        UserDetails userDetails = new UserDetails();
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, passwordFormat);
        }
        public bool ValidateMobileNo(string mobileNo)
        {
            return Regex.IsMatch(mobileNo, mobileNoFormat);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, eMailRegex);
        }
        public bool ValidatelastName(string lN)
        {
            return Regex.IsMatch(lN, lastName);
        }
        public bool ValidatefirstName(string fN)
        {
            return Regex.IsMatch(fN, firstName);
        }
    }
}
