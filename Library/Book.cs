using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        // Private fields
        private string _title;
        private string _author;
        private int _isbn;

        // Public properties
        public string Title
        {
            get { return _title; }
            set
            {
                // Check if any incoming char is a digit
                if (!value.Any(char.IsDigit))
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Title cannot contain numbers.");
                }
            }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        // Constructor

        // Methods

        public string _Title;
        public string _Author;
        public int _ISBN;

        // Paramterised constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }
    }
}