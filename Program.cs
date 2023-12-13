using System;

namespace Store
{
    public class Book
    {
        public string Title { get; }

        public int Id { get; }

        public string Author { get; }

        public int Price { get; }

        public string Describe { get; }

        public string Publishing { get; }

        public int Year { get; }

        public int Grade { get; }

        public Book(int id, int price, string author, string title,
            string describe, string publishing, int year, int grade)
        {
            Title = title;
            Id = id;
            Author = author;
            Price = price;
            Describe = describe;
            Publishing = publishing;
            Year = year;
            Grade = grade;
        }
    }
}