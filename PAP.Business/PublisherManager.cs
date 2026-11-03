using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class PublisherManager
    {
        private readonly PublisherRepository _repository = new PublisherRepository();
        public IEnumerable<Publisher> GetAll() => _repository.GetAll();
        public Publisher GetById(int id) => _repository.GetById(id);
        public void Add(Publisher item) => _repository.Add(item);
        public void Update(Publisher item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
