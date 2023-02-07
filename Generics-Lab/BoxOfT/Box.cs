using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
    {
    public class Box<T>
        {
        private int count;
        private List<T> list;
        public Box()
            {
            list= new List<T>();
            }
        public int Count { get { return this.count; } }


       public  void Add(T element)
            {
            list.Add(element);
            count ++;
            }
        public T Remove()
            {
            T removedElement = list[list.Count-1];
            list.Remove(removedElement);
            count--;
            return removedElement;
            
            }
        }
    }
