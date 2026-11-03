using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class InventoryManager
    {
        private readonly InventoryRepository _repository = new InventoryRepository();
        public IEnumerable<Inventory> GetAll() => _repository.GetAll();
        public Inventory GetById(int id) => _repository.GetById(id);
        public void Add(Inventory item) => _repository.Add(item);
        public void Update(Inventory item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
