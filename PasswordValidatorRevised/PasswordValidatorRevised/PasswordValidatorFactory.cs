using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidatorRevised
{
    public class PasswordValidatorFactory
    {
        public PasswordValidator GetPasswordValidator(string user)
        {
            if (user == "internal")
                return new InternalPasswordValidator();
            else if (user == "external")
                return new ExternalPasswordValidator();
            else
                throw new Exception("Invalid user type");
        }
    }
}
