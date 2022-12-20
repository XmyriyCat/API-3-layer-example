using BLL.DTO;
using DLL.Models;
using DLL.Repository;

namespace BLL
{
    public class CatalogService // From Interface
    {
        private readonly Repository _repository;

        public CatalogService(Repository repository)
        {
            _repository = repository;
        }

        public List<Book> GetAllBooks()
        {
            return _repository.GetAllBooks();
        }

        public Book CreateBook(CreateBookDto dto)
        {
            // Validation
            // проверка пользовательских данных!!!!
            
            //mapping
            Book book = new Book(); // from mapping

            _repository.AddBook(book);

            // book поля инициализированы
            return book;
        }
        
    }
}