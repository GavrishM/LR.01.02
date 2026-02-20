using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClassLib;

namespace test_library_system_
{
    [TestClass]
    public class LibraryTestClass
    {
        [TestMethod]
        public void LibraryConstructorTest()
        {
            string name = "biblioteka gorkogo";
            List<Book> books = new List<Book>
            {
             new Book("konek igorek", "igor igorev igorevich", 2021),
             new Book("konek ugorek", "igor igorev igorevich", 2020),
             new Book("sbornik anekdotov", "igor igorev igorevich", 2019),
             new Book("konek gorbynok", "igor igorev igorevich", 2022)
            };

            Library library = new Library(name, books);
            Library actual = library;

            Assert.AreEqual(name, actual.Name);
            Assert.AreEqual(books, actual.Books);
        }

        [TestMethod]
        public void SearchAutorsBooksTest()
        {
            string name = "biblioteka gorkogo";
            List<Book> books = new List<Book>
            {
             new Book("konek igorek", "igor igorev igorevich", 2021),
             new Book("konek ugorek", "igor igorev igorevich", 2020),
             new Book("sbornik anekdotov", "oleg igorev igorevich", 2019),
             new Book("konek gorbynok", "igor igorev igorevich", 2022)
            };

            List<Book> excepted = new List<Book>
            {
             new Book("sbornik anekdotov", "oleg igorev igorevich", 2019)
            };

            Library library = new Library(name, books);
            List<Book> actual = library.SearchAutorsBooks("oleg igorev igorevich");

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void OutputBooksTest()
        {
            string name = "biblioteka gorkogo";
            List<Book> books = new List<Book>
            {
             new Book("konek igorek", "igor igorev igorevich", 2021),
             new Book("konek ugorek", "igor igorev igorevich", 2020),
             new Book("sbornik anekdotov", "oleg igorev igorevich", 2019),
             new Book("konek gorbynok", "igor igorev igorevich", 2022)
            };

            List<Book> excepted = new List<Book>
            {
             new Book("konek igorek", "igor igorev igorevich", 2021),
             new Book("konek ugorek", "igor igorev igorevich", 2020),
             new Book("sbornik anekdotov", "oleg igorev igorevich", 2019),
             new Book("konek gorbynok", "igor igorev igorevich", 2022)
            };

            Library library = new Library(name, books);
            List<Book> actual = library.OutputBooks();

            Assert.AreEqual(excepted, actual);
        }
    }
}
