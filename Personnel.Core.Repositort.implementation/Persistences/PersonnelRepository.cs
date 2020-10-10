using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Personnel.core.Domain.Data;
using Personnel.core.Domain.Models.Domain;
using Personnel.Core.Repository.implementation.Repositories;
using Personnel.Core.Repository.Persistence;

namespace Personnel.Core.Repository.implementation.Persistences
{
    public class PersonnelRepository:Repository<Personnels>,IPersonnelRepository

    {
        public PersonnelRepository(PersonnelDbContext context) : base(context)
        {
        }
        public PersonnelDbContext PersonnelDbContext => _context as PersonnelDbContext;
        public IEnumerable<Personnels> GetPersonnelsWithDepartments()
        {
            return PersonnelDbContext.Personnels.Include("Department").ToList();
        }
    }
}
