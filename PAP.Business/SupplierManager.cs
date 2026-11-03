using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class SupplierManager
    {
        private readonly SupplierRepository _repository = new SupplierRepository();
        public IEnumerable<Supplier> GetAll() => _repository.GetAll();
        public Supplier GetById(int id) => _repository.GetById(id);
        public void Add(Supplier item) => _repository.Add(item);
        public void Update(Supplier item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
