using Data.Data;
using Data.Entities;
using Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AnnouncementRepository : IAnnouncementRepository
    {
        protected RepositoryContext _repository;
        public AnnouncementRepository(RepositoryContext repositoryContext)
        {
            _repository = repositoryContext;
        }
        public void Create(Announcement entity)
        {
            _repository.Add(entity);
        }

        public void Delete(Announcement entity)
        {
            _repository.Announcements.Remove(entity);
        }

        public async Task<IEnumerable<Announcement>> GetAllAsync()
        {
            return await _repository.Announcements.ToListAsync();
        }

        public async Task<Announcement> GetByIdAsync(int id)
        {
            return await _repository.Announcements.FindAsync(id);
        }

        public void Update(Announcement entity)
        {
            _repository.Entry(entity).State=EntityState.Modified;
        }
    }
}