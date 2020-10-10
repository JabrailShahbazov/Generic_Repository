using System.Collections.Generic;
using Personnel.core.Domain.Models.Domain;
using Personnel.Core.Repository.Repositories;

namespace Personnel.Core.Repository.implementation.Repositories
{
    public interface IDepartmentRepository:IRepository<Department>
    {
        IEnumerable<Department> GetTopDepartments(int count);
        IEnumerable<Department> GetDepartmentWithPersonnels();

    }
}
