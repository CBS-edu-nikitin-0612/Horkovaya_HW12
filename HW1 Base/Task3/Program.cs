using System;

namespace Task3
{
    class Title
    {
        private string bookName;
        public Title(string bookName)
        {
            this.bookName = bookName;
        }
        public string Show()
        {
            return bookName;
        }
    }
    class Author
    {
        private string surname;
        public Author(string surname)
        {
            this.surname = surname;
        }
        public string Show()
        {
            return surname;
        }
    }
    class Content
    {
        private string description;
        public Content(string description)
        {
            this.description = description;
        }
        public string Show()
        {
            return description;
        }
    }
    class Book 
    {
        Title title;
        Author author;
        Content content;
        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title.Show());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author.Show());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content.Show());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            string content = Console.ReadLine();
            Book book = new Book(new Title(title), new Author(author), new Content(content));
            book.Show();
            Console.ReadKey();
        }
    }
}
