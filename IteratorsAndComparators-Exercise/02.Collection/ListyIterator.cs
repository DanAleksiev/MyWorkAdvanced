using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
    {
    public class CustomListyIterator<T> : IEnumerable<T>
        {
        private int index;
        private List<T> list;
        public CustomListyIterator(List<T> aList)
            {
            index = 0;
            this.list = aList;
            }
        public List<T> List { get; set; }
        public bool Move()
            {
            if (index < list.Count - 1)
                {
                index++;
                return true;
                }
            return true;
            }
        public bool HasNext()
            {
            if (index < list.Count - 1)
                {
                return true;
                }
            return false;
            }
        public void Print()
            {
            Console.WriteLine(list[index]);
            }
        public void PrintAll()
            {
            foreach (var item in list)
                {
                Console.Write($"{item} ");
                }
            }

        public IEnumerator<T> GetEnumerator()
            {
            foreach (var item in list)
                {
                yield return item;
                }
            }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
