using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryClassLib;

namespace test_library_system_
{
    [TestClass]
    public class BookTestClass
    {
        [TestMethod]
        public void BookConstrutorTest()
        {
            string title = "konek igorek";
            string author = "igor igorev igorevich";
            int year = 2021;

            Book book = new Book(title, author, year);
            Book actual = book;

            Assert.AreEqual(title, actual.Title);
            Assert.AreEqual(author, actual.Author);
            Assert.AreEqual(year, actual.Year);
        }
    }
}
