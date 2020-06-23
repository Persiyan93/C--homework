using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Generic
{
    class BoxOf<T> where T:IComparable
    {
        public BoxOf()
        {


        }

        private T varible;

        public T Varible
        {
            get { return varible; }
            set { varible = value; }
        }
        public void ToString()
        {
            Console.WriteLine("{0}: {1}", Varible.GetType(), Varible);
        }
        public bool Compare(T element)
        {
            if (this.Varible.CompareTo(element)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        
       
    }
}
