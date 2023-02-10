using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
    {
    public class CustomListyIterator<T>
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
            if (list.Count == 0)
                {
                throw new InvalidOperationException("Invalid Operation!");
                }
            Console.WriteLine(list[index]);
            }
        }
    }
