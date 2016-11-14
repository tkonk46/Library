using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }

        public Book(string _title, string _author, string _isbn, string _genre)
        {
            Title = _title;
            Author = _author;
            ISBN = _isbn;
            Genre = _genre;

        }
    }

        
    
       
    
}
