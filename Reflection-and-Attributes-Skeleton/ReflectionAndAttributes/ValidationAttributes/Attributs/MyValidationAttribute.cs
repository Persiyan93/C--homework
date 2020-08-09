using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributs
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]
   public abstract class MyValidationAttribute:Attribute
    {
        public abstract bool IsValid(object obj);
    }
}
