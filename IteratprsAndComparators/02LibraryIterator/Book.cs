using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
    {
    public class Book
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
        }
    }
