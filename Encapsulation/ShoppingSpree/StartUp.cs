using System;

namespace ShoppingSpree
{
    
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                Data data = new Data();
                data.Run();
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
