using System;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : ICalling
    {
        public StationaryPhone()
        {

        }
       
        public string Call(string number)
        {
            if (!number.Any(ch => char.IsDigit(ch)))
            {
                throw new ArgumentException("Invalid number!");

            }
            return $"Dialing... {number}";

        }
       
    }
}
