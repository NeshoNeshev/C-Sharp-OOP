using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                IEnumerable<MyValidationAttribute> propertyCustomAtribute =
                    property.GetCustomAttributes()
                        .Where(x=>x is MyValidationAttribute)
                        .Cast<MyValidationAttribute>();
                foreach (var attribute in propertyCustomAtribute)
                {
                  bool result = attribute.IsValid(property.GetValue(obj));
                  if (!result)
                  {
                      return false;
                  }
                }
            }
            return true;
        }
    }
}
