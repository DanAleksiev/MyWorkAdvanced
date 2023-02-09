using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
    {
    public class Box<T> where T :IComparable<T>
        {
        private List<T> items;
        private int count;
        public Box()
            {
           items= new List<T>();
            count= 0;
            }

        public void Add(T item)
            {
            items.Add(item);
            }
        public void Replace(int replace, int with)
            {
            T item = items[replace];
            items[replace] = items[with];
            items[with] = item;
            }
        public int Compare(T target)
            {
            foreach(T item in items)
                {
                if (item.CompareTo(target) > 0)
                    {
                    count++;
                    }
                }
            return count;
            }
        public override string ToString()
            {
            StringBuilder sb = new StringBuilder();
            foreach (T item in items)
                {
                sb.AppendLine($"{typeof(T)}: {item} ");
                }
            return sb.ToString().TrimEnd();
            }
        }
    }
