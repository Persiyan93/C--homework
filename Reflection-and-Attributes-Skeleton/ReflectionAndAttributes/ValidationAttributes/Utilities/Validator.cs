using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributs;

namespace ValidationAttributes.Utilities
{
    public static class Validator
    
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
        public static bool IsValid(object obj)
        {
            
            if (obj==null)
            {
                return false;
            }
            Type type = obj.GetType();
            PropertyInfo[] objproperties = type.GetProperties();
            foreach (var  property in objproperties)
            {
                MyValidationAttribute[] attributes = property.GetCustomAttributes()
                    .Where(ca => ca is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();
                foreach (var attribute in attributes)
                {
                    if (!attribute.IsValid(property.GetValue(obj)))
                    {
                        return false;
                    }
                }
              

            }
            return true;

        }
    }
}
