using Resturent.Models.Entities;

namespace Resturent.Application.Resturents
{
    public interface IResturentService
    {
        Task<IEnumerable<ResturentProp>> GetAllResturents();
    }
}