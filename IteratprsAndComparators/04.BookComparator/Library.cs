using _04.BookComparator;
using IteratorsAndComparators;
using System;
using System.Collections;

namespace _01.Library
    {
    public class Library : IEnumerable<Book>
        {
        public Library(params Book[] books)
            {
            Books = books.ToList();
            }
        public List<Book> Books { get; set; }
        public IEnumerator<Book> GetEnumerator()
            {
            Books.Sort(new BookComparator()); //sort them alphabeticly and then by year
            return Books.GetEnumerator();
            }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public class LibraryIterator : IEnumerator<Book>
            {
            private readonly List<Book> books;
            private int currentIndex;
            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => throw new NotImplementedException();


            public bool MoveNext() => ++this.currentIndex < this.books.Count;

            public void Reset() => this.currentIndex = -1;
            public void Dispose() { }
            }
        }
    }
