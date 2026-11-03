using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class ReviewManager
    {
        private readonly ReviewRepository _repository = new ReviewRepository();
        public IEnumerable<Review> GetAll() => _repository.GetAll();
        public Review GetById(int id) => _repository.GetById(id);
        public void Add(Review item) => _repository.Add(item);
        public void Update(Review item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
