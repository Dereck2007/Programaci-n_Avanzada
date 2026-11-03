using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class PurchaseOrderManager
    {
        private readonly PurchaseOrderRepository _repository = new PurchaseOrderRepository();
        public IEnumerable<PurchaseOrder> GetAll() => _repository.GetAll();
        public PurchaseOrder GetById(int id) => _repository.GetById(id);
        public void Add(PurchaseOrder item) => _repository.Add(item);
        public void Update(PurchaseOrder item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
