using System;

namespace Telephony
{
    public class Engine
    {
        public Engine()
        {

        }
        public void Run()
        {
            var numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            foreach (var number in numbers)
            {
                if (number.Length==10)
                {
                    Smartphone smart = new Smartphone();
                    try
                    {
                        Console.WriteLine(smart.Call(number));
                    }
                    catch (ArgumentException ae)
                    {

                        Console.WriteLine(ae.Message);
                    }
                     
                }
                else if (number.Length == 7)
                {
                    StationaryPhone phone = new StationaryPhone();
                    try
                    {
                        Console.WriteLine(phone.Call(number));
                    }
                    catch (ArgumentException ae)
                    {

                        Console.WriteLine(ae.Message);
                    }
                    
                   
                }
            }
            var sites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in sites)
            {
                Smartphone smart = new Smartphone();
                try
                {
                    
                    Console.WriteLine(smart.Browse(item));
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
