using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidatorRevised
{
    public class ExternalPasswordValidator:PasswordValidator
    {
        int conditionCount = 0;
        public override bool GetResult(string password)
        {
            if ( IsPasswordNotNull(password))
                return true;
            else if (IsLengthOfPasswordGreaterThan8(password))
                return true;
            else if (DoesPasswordContainAnyUpperCase(password))
                return true;
            else if (DoesPasswordContainAnyLowerCase(password))
                return true;
            else if (DoesPasswordContainAnyNumber(password))
                return true;
            else
                return false;
        }
        bool IsPasswordNotNull(string password)
        {
            conditionCount++;
            if (password != null)
                return true;
            else
                throw new Exception("Password is null");
        }
        bool IsLengthOfPasswordGreaterThan8(string password)
        {
            conditionCount++;
            if (password.Length > 8)
                return true;
            else
                throw new Exception("Password is not larger than 8 characters");
        }
        bool DoesPasswordContainAnyUpperCase(string password)
        {
            conditionCount++;
            if (password.Any(char.IsUpper))
                return true;
            else
                throw new Exception("Password doesnot contain any upper case character");
        }
        bool DoesPasswordContainAnyLowerCase(string password)
        {
            conditionCount++;
            if (password.Any(char.IsLower))
                return true;
            else
                throw new Exception("Password doesnot contain any Lower case character");
        }
        bool DoesPasswordContainAnyNumber(string password)
        {
            conditionCount++;
            if (password.Any(char.IsDigit))
                return true;
            else
                throw new Exception("Password doesnot contain any number");
        }
        bool DoesPasswordSatifyAnyThreeVerificationConditions(string password)
        {
            if (conditionCount > 2)
                return true;
            else
                throw new Exception("Password Does not satify feature 2");
        }
        bool DoesPasswordSatifiesUpperCaseCondition(string password)
        {
            if (DoesPasswordContainAnyUpperCase(password))
                return true;
            else
                throw new Exception("Password Does not satify feature 3");
        }
    }
}
