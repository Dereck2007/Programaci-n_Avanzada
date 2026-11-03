using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class CartItemManager
    {
        private readonly CartItemRepository _repository = new CartItemRepository();
        public IEnumerable<CartItem> GetAll() => _repository.GetAll();
        public CartItem GetById(int id) => _repository.GetById(id);
        public void Add(CartItem item) => _repository.Add(item);
        public void Update(CartItem item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
