using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class AuthorManager
    {
        private readonly AuthorRepository _repository = new AuthorRepository();
        public IEnumerable<Author> GetAll() => _repository.GetAll();
        public Author GetById(int id) => _repository.GetById(id);
        public void Add(Author item) => _repository.Add(item);
        public void Update(Author item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
