
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emails
{
    public static class Email
    {
        public static bool VerificarEmail(string email)
        {
            if(!email.Contains("@") || !email.Contains(".com")){
                return false;
            }
            return true;
        }
    }
}
