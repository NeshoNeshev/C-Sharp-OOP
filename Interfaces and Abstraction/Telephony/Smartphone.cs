using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICalling, IBrowsing

    {
        public Smartphone()
        {
           
        }
        public string Model { get;private set; }
        public string Browse(string url)
        {
            if (url.Any(ch => char.IsDigit(ch)))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {url}!";
        }



        public string Call(string number)
        {
            if (number.Any(ch => !char.IsDigit(ch)))
            {
                throw new ArgumentException("Invalid number!");

            }
            return $"Calling... {number}";
        }
      
       
    }
}
