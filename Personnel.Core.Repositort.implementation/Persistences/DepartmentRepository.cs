using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Personnel.core.Domain.Data;
using Personnel.core.Domain.Models.Domain;
using Personnel.Core.Repository.implementation.Repositories;
using Personnel.Core.Repository.Persistence;

namespace Personnel.Core.Repository.implementation.Persistences
{
    public class DepartmentRepository: Repository<Department> ,IDepartmentRepository
    {
        public DepartmentRepository(PersonnelDbContext context) : base(context)
        {
        }
        public PersonnelDbContext PersonnelDbContext=>_context as PersonnelDbContext;

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonnelDbContext.Departments.Take(count);
        }

        public IEnumerable<Department> GetDepartmentWithPersonnels()
        {
            return PersonnelDbContext.Departments.Include("Personels").ToList();
        }
    }
}
