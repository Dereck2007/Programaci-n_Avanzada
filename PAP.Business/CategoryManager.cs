using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class CategoryManager
    {
        private readonly CategoryRepository _repository = new CategoryRepository();
        public IEnumerable<Category> GetAll() => _repository.GetAll();
        public Category GetById(int id) => _repository.GetById(id);
        public void Add(Category item) => _repository.Add(item);
        public void Update(Category item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
