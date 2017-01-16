using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidatorRevised
{
    public abstract class PasswordValidator
    {
         public abstract bool GetResult(string password);        
    }
}
