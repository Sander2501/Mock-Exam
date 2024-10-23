using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Mock_Exam_7
{
    internal class Book
    {
        public string Title;
        public string Author;
        public double Price;
        public int Pages;

        public Book(string title, string author, double price, int pages)
        {
            Title = title;
            Author = author;
            Price = price;
            Pages = pages;
        }

        public string GetDescription()
        {
            return $"{Title} by {Author} price is {Price:0.00} and amount of pages is {Pages}.";
        }
    }
}
