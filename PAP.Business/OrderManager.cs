using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class OrderManager
    {
        private readonly OrderRepository _repository = new OrderRepository();
        public IEnumerable<Order> GetAll() => _repository.GetAll();
        public Order GetById(int id) => _repository.GetById(id);
        public void Add(Order item) => _repository.Add(item);
        public void Update(Order item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
