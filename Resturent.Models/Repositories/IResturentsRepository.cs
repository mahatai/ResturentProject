using Resturent.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent.Models.Repositories
{
    public interface IResturentsRepository
    {
        public Task<IEnumerable<ResturentProp>> GetAllAsync();
    }
}
