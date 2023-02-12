using IteratorsAndComparators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace IteratorsAndComparators
    {
    public class Library : IEnumerable<Book>
        {
        private List<Book> books;
        public Library(params Book[] books)
            {
            this.Books = books.ToList();
            }
        public List<Book> Books { get; set; }
        //public IEnumerator<Book> GetEnumerator()  //easy way
        //    {
        //    return Books.GetEnumerator(); 
        //    }
        public IEnumerator<Book> GetEnumerator()
            {
            //for (int i = 0; i < books.Count; i++)
            //{
            //    yield return books[i];
            //}

            return new LibraryIterator(Books);
            }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator(); //legacy (always do this)
        public class LibraryIterator : IEnumerator<Book>
            {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
                {
                this.books = books;
                books.Sort(new BookComparator());
                currentIndex = -1;
                }

            public Book Current
                {
                get { return books[currentIndex]; }
                }

            object IEnumerator.Current => Current;

            public void Dispose()
                {
                }

            public bool MoveNext()
                {
                return ++currentIndex < books.Count;
                }

            public void Reset()
                {
                }
            }
        }
    }
