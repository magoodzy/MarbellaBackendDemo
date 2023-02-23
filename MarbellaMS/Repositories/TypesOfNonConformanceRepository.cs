using MarbellaMS.Entities;
using MarbellaMS.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Repositories
{
    public class TypesOfNonConformanceRepository : GenericRepostory<TypesOfNonConformance>, ITypesOfNonConformanceRepository
    {
        private readonly ApplicationDbContext _context;
        public TypesOfNonConformanceRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _context = dbcontext ?? throw new ArgumentNullException(nameof(dbcontext));
        }
    }
}
