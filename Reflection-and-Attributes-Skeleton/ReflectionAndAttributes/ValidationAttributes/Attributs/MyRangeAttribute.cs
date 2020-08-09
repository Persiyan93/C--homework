using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributs
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxValue;
        public MyRangeAttribute(int minvalue,int maxvalue)
        {
            this.minValue = minvalue;
            this.maxValue = maxvalue;
        }
        public override bool IsValid(object obj)
        {
            if (obj is Int32)
            {
                int value = (int)obj;
                if (value>=minValue&&value<=maxValue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new InvalidCastException("Cannot validate given data type!");
            }
        }
    }
}
