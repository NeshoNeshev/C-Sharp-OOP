using System;

namespace WildFarm.Model.Animal
{
    public class InvalidPreferedFoodException:Exception
    {
        public InvalidPreferedFoodException(string message) : base(message)
        {
        }
    }
}
