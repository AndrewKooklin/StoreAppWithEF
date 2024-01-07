using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;

namespace StoreWithEF.HelpMethods
{
    public class CheckTextAddClientForm
    {
        public bool CheckName(string text)
        {
            if (Regex.IsMatch(text, "^[a-zA-Z]{3,}"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CheckPhone(string text)
        {
            if (Regex.IsMatch(text, "^[0-9]{11}"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool CheckEmail(string text)
        {
            try
            {
                MailAddress m = new MailAddress(text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }
    }
}
