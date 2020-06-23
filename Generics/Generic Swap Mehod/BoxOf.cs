using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class BoxOf<T>
    {

        public  BoxOf()
        {
           

        }

        private   T varible;

        public  T Varible
        {
            get { return varible; }
            set { varible = value; }
        }
        public void ToString()
        {
            Console.WriteLine("{0}: {1}", Varible.GetType(), Varible);
        }


    }
}
