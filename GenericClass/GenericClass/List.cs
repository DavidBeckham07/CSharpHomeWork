using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    class List<T>
    {
        
        public List<T> next;
        public T Data { get; set; }

        public List(T t)
        {
            next = null;
            Data = t;
        }


        public void add(T t)
        {
            List<T> current = this;
            while (current.next != null)
            {
                current = current.next;
            }
            List<T> next = new List<T>(t);
            current.next = next;
        }

        internal void ForEach( Action<T> action)
        {
            List<T> current = this;
            while(current != null)
            {
                action(current.Data);
                current = current.next;
            }
        }

 


    }

}
