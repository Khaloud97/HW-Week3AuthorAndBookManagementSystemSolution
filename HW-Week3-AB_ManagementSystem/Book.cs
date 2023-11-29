
namespace HW_Week3_AB_ManagementSystem
{
    internal class Book
    {
        public string title;
        public int publicationYear;
        public string genre;


        public Book()
        {

        }

        public Book(string title, int publicationYear, string genre)
        {
            this.title = title;
            this.publicationYear = publicationYear;
            this.genre = genre;
        }




        //body Expression Method for displayBookInfo
        public string displayBookInfo() => $"\nDisplaying Books for J.K. Rowling:" +
            $"\nBooks Authored by J.K. Rowling:"+
            $"\nTitle: {this.title} " +
            $"\nPublication Year: : {this.publicationYear} " +
            $"\nGenre: {this.genre}";

    }

}

