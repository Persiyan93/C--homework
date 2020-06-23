using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Box<T>
    {
        private T value1;

        public T Value1
        {
            get { return value1; }
            set { value1 = value; }
        }
        public void ToString()
        {
            Console.WriteLine("{0}: {1}",Value1.GetType(),Value1);
        }
       
    }
}
