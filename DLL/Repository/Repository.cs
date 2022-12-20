using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Models;

namespace DLL.Repository
{
    public class Repository // делаем запросы в БД
    {
        public List<Book> GetAllBooks()
        {
            // сделали запрос в БД через EF core
            return new List<Book>();
        }

        public Book AddBook(Book book)
        {
            // запрос на добавление book
            return book;
        }
    }
}
