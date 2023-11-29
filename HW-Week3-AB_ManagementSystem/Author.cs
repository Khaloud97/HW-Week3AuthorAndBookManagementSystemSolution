
namespace HW_Week3_AB_ManagementSystem
{
    internal class Author
    {
        public string authorName;
        public int birthYear;
        public string nationality;


        public Author()
        {

        }

        public Author(string authorName, int birthYear, string nationality)
        {
            this.authorName = authorName;
            this.birthYear = birthYear;
            this.nationality = nationality;
        }

        // Author with Many Books:
        List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public void AllDisplayBooks() {


            foreach (Book book in this.books)
            {

                Console.WriteLine($"\nAdding Books for J.K. Rowling : \n {book.displayBookInfo()} \n");

            }

        }

    
    //body Expression Method for displayAuthorInfo
    public string displayAuthorInfo() => $"Author Information:" +
        $"\nName: {this.authorName} " +
        $"\nBirth Year: {this.birthYear} " +
        $"\nNationality: {this.nationality}";

    }
    
     

   
}
