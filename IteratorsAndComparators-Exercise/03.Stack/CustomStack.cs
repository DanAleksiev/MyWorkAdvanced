using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
    {
    public class CustomStack<T> : IEnumerable
        {
        private const int InitialCapacity = 4;
        private T[] items;

        public CustomStack()
            {
            items = new T[InitialCapacity];
            }

        public int Count { get; private set; }
        public IEnumerator<T> GetEnumerator()
            {
            foreach (var item in items)
                {
                yield return item;
                }
            }

        public void Pop()
            {
            if (Count == 0)
                {
                throw new InvalidOperationException("No elements");
                }
            }

        public void Push(T item)
            {
            if (items.Length == Count)
                {
                Resize();
                }
            items[Count] = item;
            Count++;
            }
        public void Resize()
            {
            T[] temp = new T[items.Length * 2];
            for (int i = 0; i < Count; i++)
                {
                temp[i] = items[i];
                }
            items = temp;
            }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }