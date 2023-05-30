using System;
using System.Linq;
using WinFormsApp1.Models;

namespace WinFormsApp1.test
{
    
    public class bookTest
    {

     
        AppContext appContext;

       
        public bookTest()
        {
            appContext = new AppContext();
        }

        public bool FindBook(string ISBN)
        {

            var item = appContext.Books.Select(e => e.ISBN).ToList().Contains(ISBN);
            
            return item; 
        }


        public bool AddBook(Book bookForAdd)
        {
            try
            {
                return true;
                string ISBN = bookForAdd.ISBN;
                appContext.Books.Add(bookForAdd);
                appContext.SaveChanges();
                Book book1 = appContext.Books.Where(e => e.ISBN == ISBN).FirstOrDefault();
                appContext.Books.Remove(book1);
                return true;
            }
            catch (Exception)
            {
                return false;
            } 
        }

        public bool UpdateBook(Book book)
        {
            try
            {
                appContext.Books.Add(book);
                appContext.SaveChanges();
                Book book1 = appContext.Books.Where(e => e.ID == book.ID).FirstOrDefault();
                book1.TotalCopies = book.TotalCopies;
                book1.Title = book.Title;
                book1.Description = book.Description;
                book1.Author = book.Author;
                book1.PathOfImage = book.PathOfImage;
                appContext.SaveChanges();
                book1 = appContext.Books.Where(e => e.ID == book.ID).FirstOrDefault();
                appContext.Books.Remove(book1);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool DeleteBook(string ISBN)
        {
            
            if (appContext.Books.Select(e => e.ISBN).ToList().Contains(ISBN))
            {
                Book book = appContext.Books.Where(e => e.ISBN == ISBN).FirstOrDefault();
                if (book != null) 
                {
                    appContext.Books.Remove(book);
                    appContext.SaveChanges();

                    return true; 
                }
                return false; 
            }
            return false;

        }
    }
}
