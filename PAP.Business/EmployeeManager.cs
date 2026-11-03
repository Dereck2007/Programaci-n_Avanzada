using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;
namespace PAP.Business
{
    // Capa de negocio: delega el acceso al repositorio especifico.
    public class EmployeeManager
    {
        private readonly EmployeeRepository _repository = new EmployeeRepository();
        public IEnumerable<Employee> GetAll() => _repository.GetAll();
        public Employee GetById(int id) => _repository.GetById(id);
        public void Add(Employee item) => _repository.Add(item);
        public void Update(Employee item) => _repository.Update(item);
        public void Delete(int id) => _repository.Delete(id);
    }
}
