using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordValidatorRevised;
namespace PasswordValidatorTest
{
    [TestClass]
    public class UnitTest1
    {
        private static PasswordValidator ConstructValidator(string user)
        {
            var validatorFactory = new PasswordValidatorFactory();
            var validator = validatorFactory.GetPasswordValidator(user);
            return validator;
        }

        [TestMethod]
        public void PasswordWithLengthLargerThan8ReturnsTrue()
        {
            var validator = ConstructValidator("internal");
            var result = validator.GetResult("12345678");
            Assert.AreEqual(true, result, "The Result is false");        }

        
        [TestMethod]
        public void NullPasswordReturnsTrue()
        {
            var validator = ConstructValidator("external");
            var result = validator.GetResult("");
            Assert.AreEqual(true, result, "The Result is false");
        }
        [TestMethod]
        public void PasswordWithAtLeastOneUpperCaseReturnsTrue()
        {
            var validator = ConstructValidator("external");
            var result = validator.GetResult("A123");
            Assert.AreEqual(true, result, "The Result is false");
        }
        [TestMethod]
        public void PasswordWithAtLeastOneLowerCaseReturnsTrue()
        {
            var validator = ConstructValidator("external");
            var result = validator.GetResult("a234");
            Assert.AreEqual(true, result, "The Result is false");
        }
        [TestMethod]
        public void PasswordWithAtLeastOneNumberReturnsTrue()
        {
            var validator = ConstructValidator("external");
            var result = validator.GetResult("ase3");
            Assert.AreEqual(true, result, "The Result is false");
        }
        [TestMethod]
        public void PasswordSatisfyingAny3VerificationConditionsReturnsTrue()
        {
            var validator = ConstructValidator("external");
            var result = validator.GetResult("123A");
            Assert.AreEqual(true, result, "The Result is false");
        }
        [TestMethod]
        public void PassworSatisfyingUpperCaseConditionsReturnsTrue()
        {
            var validator = ConstructValidator("external");
            var result = validator.GetResult("213A");
            Assert.AreEqual(true, result, "The Result is false");
        }

    }
}
