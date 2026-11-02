using PAP.DataAccess;
using System.Collections;
using System.Collections.Generic;
using PAP.Repositories;
namespace PAP.Business
{
    public class BookManager
    {
        private readonly BookRepository _repository;

        public BookManager()
        {
            _repository = new BookRepository();
        }

        public IEnumerable<Book> GetAllBooksFromDataModel()
        {
            return _repository.GetAll();
        }   
    }
}
