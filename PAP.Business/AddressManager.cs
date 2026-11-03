using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class AddressManager
    {
        private readonly AddressRepository _repository = new AddressRepository();
        public IEnumerable<Address> GetAll() => _repository.GetAll();
        public Address GetById(int id) => _repository.GetById(id);
        public void Add(Address item) => _repository.Add(item);
        public void Update(Address item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
