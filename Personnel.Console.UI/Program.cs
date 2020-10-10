using System;
using Personnel.core.Domain.Data;
using Personnel.core.Domain.Models.Domain;
using Personnel.Core.UnitOfWork.Persistence;

namespace Personnel.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelDbContext());
            unitOfWork.Department.Add(new Department()
            {
                Name = "Robotic",
                IsActive = true,
                CreatedDate = DateTime.Now
            });
            unitOfWork.Complete();
        }
    }
}
