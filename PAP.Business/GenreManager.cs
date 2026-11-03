using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class GenreManager
    {
        private readonly GenreRepository _repository = new GenreRepository();
        public IEnumerable<Genre> GetAll() => _repository.GetAll();
        public Genre GetById(int id) => _repository.GetById(id);
        public void Add(Genre item) => _repository.Add(item);
        public void Update(Genre item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
