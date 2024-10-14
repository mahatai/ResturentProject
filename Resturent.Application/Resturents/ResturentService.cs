using Microsoft.Extensions.Logging;
using Resturent.Models.Entities;
using Resturent.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent.Application.Resturents
{
    internal class ResturentService(IResturentsRepository resturentsRepository, ILogger<ResturentService> logger) : IResturentService
    {
        public async Task<IEnumerable<ResturentProp>> GetAllResturents()
        {
            logger.LogInformation("Getting all resturents");
            var resturents = await resturentsRepository.GetAllAsync();
            return resturents;

        }
    }
}
