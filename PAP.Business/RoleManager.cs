using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class RoleManager
    {
        private readonly RoleRepository _repository = new RoleRepository();
        public IEnumerable<Role> GetAll() => _repository.GetAll();
        public Role GetById(int id) => _repository.GetById(id);
        public void Add(Role item) => _repository.Add(item);
        public void Update(Role item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
