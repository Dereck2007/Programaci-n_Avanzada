using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class CustomerManager
    {
        private readonly CustomerRepository _repository = new CustomerRepository();
        public IEnumerable<Customer> GetAll() => _repository.GetAll();
        public Customer GetById(int id) => _repository.GetById(id);
        public void Add(Customer item) => _repository.Add(item);
        public void Update(Customer item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
