using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class PurchaseOrderItemManager
    {
        private readonly PurchaseOrderItemRepository _repository = new PurchaseOrderItemRepository();
        public IEnumerable<PurchaseOrderItem> GetAll() => _repository.GetAll();
        public PurchaseOrderItem GetById(int id) => _repository.GetById(id);
        public void Add(PurchaseOrderItem item) => _repository.Add(item);
        public void Update(PurchaseOrderItem item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
