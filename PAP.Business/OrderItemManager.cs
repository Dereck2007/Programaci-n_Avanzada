using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class OrderItemManager
    {
        private readonly OrderItemRepository _repository = new OrderItemRepository();
        public IEnumerable<OrderItem> GetAll() => _repository.GetAll();
        public OrderItem GetById(int id) => _repository.GetById(id);
        public void Add(OrderItem item) => _repository.Add(item);
        public void Update(OrderItem item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
