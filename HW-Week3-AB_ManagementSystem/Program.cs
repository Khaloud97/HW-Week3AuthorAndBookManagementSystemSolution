using System;
using System.Diagnostics.Metrics;
using System.Net;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace HW_Week3_AB_ManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Author and Book Management System!");


            Author author = new Author("J.K. Rowling", 1965, "Fantasy");
            Console.WriteLine(author.displayAuthorInfo());
            
            //Console.WriteLine($"\nAdding Books for J.K. Rowling:");

            while (true)
            {
                Console.Write("\nEnter Book Title:  "); //what if user enter string or more than 100 or less than 0
                string title = Console.ReadLine();

                Console.Write("Enter Publication Year: ");
                int.TryParse(Console.ReadLine(), out int publicationYear);

                Console.Write("Enter Genre: ");
                string genre = Console.ReadLine();


               
                // author.AddBook(Book.books);
                Book b = new Book(title, publicationYear, genre);
                author.AddBook(b);
                author.AllDisplayBooks();

            }

            /*Book b = new Book(out title, publicationYear, genre);
            author.AddBook(b);
            author.AllDisplayBooks();*/

            // Console.WriteLine(Author.AllDisplayBooks());


            //Console.WriteLine(author.displayBookInfo());
            //author.AllDisplayBooks();

            /* Book b = new Book(title, publicationYear, genre);
            Console.WriteLine($"\nAdding Books for  : \n {b.displayBookInfo()} \n");

             List<Book> books = new List<Book>();
            
            foreach (Book books in this.books)
            {
    
                Console.WriteLine($"\nAdding Books for  : \n {b.displayBookInfo()} \n");

            }*/

        }
    }
}