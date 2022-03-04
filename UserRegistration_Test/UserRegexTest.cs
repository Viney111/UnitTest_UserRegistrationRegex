using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationRegex;

namespace UserRegistration_Test
{
    [TestClass]
    public class UserRegexTest
    {
        //Arrange
        User_Registration_Regex user_Registration_Regex = new User_Registration_Regex();
        [TestMethod]
        public void RightFirstNameTestMethod_ReturnTrue()
        {
            //Add
            bool result = user_Registration_Regex.ValidatefirstName("Viney");
            //Assert
            Assert.AreEqual(true,result);
        }
        [TestMethod]
        public void RightLastNameTestMethod_ReturnTrue()
        {
            bool result = user_Registration_Regex.ValidatelastName("Khaneja");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void RightEmailTestMethod_ReturnTrue()
        {
            bool result = user_Registration_Regex.ValidateEmail("vineykhaneja@bl.co");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void RightPasswordTestMethod_ReturnTrue()
        {
            bool result = user_Registration_Regex.ValidatePassword("aaaaAsdd@323");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void RightMobileNumberTestMethod_ReturnTrue()
        {
            bool result = user_Registration_Regex.ValidateMobileNo("91 7206594149");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void WrongFirstNameTestMethod_ReturnFalse()
        {
            //Add
            bool result = user_Registration_Regex.ValidatefirstName("viney");
            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void WrongLastNameTestMethod_ReturnFalse()
        {
            bool result = user_Registration_Regex.ValidatelastName("khaneja");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void WrongEmailTestMethod_ReturnFalse()
        {
            bool result = user_Registration_Regex.ValidateEmail("vineykhanbl.co");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void WrongPasswordTestMethod_ReturnFalse()
        {
            bool result = user_Registration_Regex.ValidatePassword("aaaaAsdd323");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void WrongMobileNumberTestMethod_ReturnFalse()
        {
            bool result = user_Registration_Regex.ValidateMobileNo("7206594149");
            Assert.AreEqual(false, result);
        }
    }
}