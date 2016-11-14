using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Library
{
    class CardCatalog
    {
        private string _filename;
        private Book book;
         

        List<Book> books = new List<Book>()
        {
            
        };

        public CardCatalog()
        {

        }

        public CardCatalog(string fileName)
        {
            _filename = fileName;
        }

        public void ListBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine(book.Title);
            }
        }

        public void AddBook()
        {
            Console.Write("Enter the book's title ");
            string _title = Console.ReadLine();
            Console.Write("Enter the author ");
            string _author = Console.ReadLine();
            Console.Write("Enter the ISBN ");
            string _isbn = Console.ReadLine();
            Console.Write("Enter the genre ");
            string _genre = Console.ReadLine();
            books.Add(new Book(_title, _author, _isbn, _genre));

        }

            public void Save()
         {
             XmlSerializer x = new XmlSerializer(_cardCatalog.GetType());
             x.Serialize(Console.Out, _cardCatalog);
           
         }
    }
}
