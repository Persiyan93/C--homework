using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
      

        public string Browse(string website)
        {
            StringBuilder sb = new StringBuilder();
            bool hasDigit = website.Any(char.IsDigit);
            if (hasDigit)
            {
                sb.Append( "Invalid URL!");
            }
            else
            {
                sb.Append($"Browsing: {website}!");
            }
            return sb.ToString();
        }

        public string Call(string number)
        {
            StringBuilder sb = new StringBuilder();

            bool IsonlyNumber = number.Any(char.IsDigit);
            if (IsonlyNumber)
            {
                if (number.Length==10)
                {
                    sb.Append($"Calling... {number}");
                }
                else if(number.Length==7)
                {
                    sb.Append($"Dialing... {number}");
                }
                else
                {
                    sb.Append("Invalid number!");
                }
            }
            else
            {
                sb.Append("Invalid number!");
            }
            return sb.ToString();
        }
    }
}
