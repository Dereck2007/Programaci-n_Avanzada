using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class ShoppingCartManager
    {
        private readonly ShoppingCartRepository _repository = new ShoppingCartRepository();
        public IEnumerable<ShoppingCart> GetAll() => _repository.GetAll();
        public ShoppingCart GetById(int id) => _repository.GetById(id);
        public void Add(ShoppingCart item) => _repository.Add(item);
        public void Update(ShoppingCart item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
