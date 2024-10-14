using Microsoft.EntityFrameworkCore;
using Resturent.Infrastructure.Persistance;
using Resturent.Models.Entities;
using Resturent.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent.Infrastructure.Repository
{
    internal class ResturentRepository(ResturentDbContext resturentDbContext) : IResturentsRepository
    {
        public async Task<IEnumerable<ResturentProp>> GetAllAsync()
        {
            return await resturentDbContext.Resturents.ToListAsync();
        }
    }
}
