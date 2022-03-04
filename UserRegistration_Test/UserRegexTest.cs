using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationRegex;

namespace UserRegistration_Test
{
    [TestClass]
    public class UserRegexTest
    {
        //Arrange
        User_Registration_Regex user_Registration_Regex = new User_Registration_Regex();
        UserDetails userDetails = new UserDetails();
        [TestMethod]
        public void RightFirstNameTestMethod_ReturnTrue()
        {
            //Add
            string result = user_Registration_Regex.ValidatefirstName("Viney");
            //Assert
            Assert.AreEqual("Viney is Valid".ToUpper(), result);
        }
        [TestMethod]
        public void RightLastNameTestMethod_ReturnTrue()
        {
            string result = user_Registration_Regex.ValidatelastName("Khaneja");
            Assert.AreEqual("Khaneja is valid".ToUpper(), result);
        }
        [TestMethod]
        public void RightEmailTestMethod_ReturnTrue()
        {
            string result = user_Registration_Regex.ValidateEmail("viney@bl.co");
            Assert.AreEqual("viney@bl.co is valid".ToUpper(), result);
        }
        [TestMethod]
        public void RightPasswordTestMethod_ReturnTrue()
        {
            string result = user_Registration_Regex.ValidatePassword("3515156Aw@hv");
            Assert.AreEqual("3515156Aw@hv is valid".ToUpper(), result);
        }
        [TestMethod]
        public void RightMobileNumberTestMethod_ReturnTrue()
        {
            string result = user_Registration_Regex.ValidateMobileNo("91 7206594149");
            Assert.AreEqual("91 7206594149 is valid".ToUpper(), result);
        }
        [TestMethod]
        public void WrongFirstNameTestMethod_ReturnFalse()
        {
            //Add
            string result = user_Registration_Regex.ValidatefirstName("viney");
            //Assert
            Assert.AreEqual("viney is invalid".ToUpper(), result);
        }
        [TestMethod]
        public void WrongLastNameTestMethod_ReturnFalse()
        {
            string result = user_Registration_Regex.ValidatelastName("khanejja");
            Assert.AreEqual("khanejja is invalid".ToUpper(), result);
        }
        [TestMethod]
        public void WrongEmailTestMethod_ReturnFalse()
        {
            string result = user_Registration_Regex.ValidateEmail("bjhcb");
            Assert.AreEqual("bjhcb is invalid".ToUpper(), result);
        }
        [TestMethod]
        public void WrongPasswordTestMethod_ReturnFalse()
        {
            string result = user_Registration_Regex.ValidatePassword("jdsk");
            Assert.AreEqual("jdsk is invalid".ToUpper(), result);
        }
        [TestMethod]
        public void WrongMobileNumberTestMethod_ReturnFalse()
        {
            string result = user_Registration_Regex.ValidateMobileNo("jbcb");
            Assert.AreEqual("jbcb is invalid".ToUpper(), result);
        }
    }
}