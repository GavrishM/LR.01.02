using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassLib
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Library(string name, List<Book> books)
        {
            Name = name;
            Books = books;
        }

        public List<Book> SearchAutorsBooks(string author) 
        {
            List<Book> result = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Author == author)
                {
                    result.Add(book);
                }
            }
            return result;
        }


    }
}
