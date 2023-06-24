using Data.Data;
using Interfaces;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private RepositoryContext _repositoryContext;
        private AnnouncementRepository _announcementRepository;
        public UnitOfWork(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IAnnouncementRepository Announcement
        {
            get
            {
                return _announcementRepository ??= new AnnouncementRepository(_repositoryContext);
            }
        }

        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
