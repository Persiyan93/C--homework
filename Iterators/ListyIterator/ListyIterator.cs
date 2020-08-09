using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    class ListyIterator<T> 
    {
        private List<T> colection = new List<T>();

        public List<T> Colection
        {
            get { return colection; }
            set { colection = value; }
        }

        public ListyIterator(IEnumerator<T> element)
        {
            Colection.Add(element);
        }
        private int curentindex = 0;
        public T Current => this.Colection[curentindex];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        { }

        public bool Move()
        {
            curentindex++;
            return curentindex < this.Colection.Count;
        }

        public bool HasNext()
        {
            if (curentindex < Colection.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Print()
        {
            if (Colection.Count!=0)
            {
                Console.WriteLine(Colection[curentindex]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}
