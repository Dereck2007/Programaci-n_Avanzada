using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class PaymentManager
    {
        private readonly PaymentRepository _repository = new PaymentRepository();
        public IEnumerable<Payment> GetAll() => _repository.GetAll();
        public Payment GetById(int id) => _repository.GetById(id);
        public void Add(Payment item) => _repository.Add(item);
        public void Update(Payment item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
