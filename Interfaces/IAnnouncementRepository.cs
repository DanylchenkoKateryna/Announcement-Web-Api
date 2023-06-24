using Data.Entities;
using System.Linq.Expressions;

namespace Interfaces
{
    public interface IAnnouncementRepository
    {
        Task<IEnumerable<Announcement>> GetAllAsync();
        Task<Announcement> GetByIdAsync(int id);
        void Create(Announcement entity);
        void Update(Announcement entity);
        void Delete(Announcement entity);
    }
}