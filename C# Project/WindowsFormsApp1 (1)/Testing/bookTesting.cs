using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WinFormsApp1.Models;
using WinFormsApp1.test;

namespace Testing
{
    [TestClass]
    public class bookTesting
    {

        [TestMethod]
        public void FindBookTesting()
        {
            bookTest bookTest = new bookTest();

            var result = bookTest.FindBook("9780142410363"); 
            Assert.IsTrue(result);

        }



        [TestMethod]
        public void AddBookTesting()
        {
            Book book = new Book() { ISBN = "9780321584106", Title = "my natural book" };
            bookTest bookTest = new bookTest();
            var result = bookTest.AddBook(book);
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void UpdateBookTesting()
        {
            Book book = new Book() { ISBN = "9780321584106", Title = "my natural book" };
            bookTest bookTest = new bookTest();
            var result = bookTest.UpdateBook(book);
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeleteBookTesting()
        {

            bookTest bookTest = new bookTest();
            var result = bookTest.DeleteBook("9780321584106");
            Assert.IsTrue(result);

        }


    }
}
