using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
    {
    public class Book : IComparable<Book>
        {
        public Book(string title,int year, params string[] author)
            {
            Title = title;
            Year = year;
            Author = author.ToList();
            }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Author { get; set;}

        public int CompareTo(Book other)
            {
            int result = this.Year.CompareTo(other.Year); // result is equal to  -1 /0/1 
            if (result == 0 )                                             // where -1 means this.Year is smaller / 0 equals/ 1 bigger
                {
                result =this.Title.CompareTo(other.Title);
                }
            return result;
            }
        public override string ToString()
            {
            return $"{this.Title} - {this.Year}";
            }
        }
    }
