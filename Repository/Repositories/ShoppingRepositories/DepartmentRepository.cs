using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AllaiaDbContext _context;
        public  DepartmentRepository(AllaiaDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Department> GetDepartmentsWithCategory()
        {
            return _context.Departments.Include("Categories")
                                         .Where(d => d.Status)
                                         .ToList();
        }
    }
}
