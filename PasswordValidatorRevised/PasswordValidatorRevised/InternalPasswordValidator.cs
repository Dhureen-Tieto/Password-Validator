using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidatorRevised
{
    public class InternalPasswordValidator: PasswordValidator
    {
        public override bool GetResult(string password)
        {
            if (password.Length >= 8)
                return true;
            else
                throw new Exception();
        }
        
    }
}
