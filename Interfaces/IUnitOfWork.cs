
namespace Interfaces
{
    public interface IUnitOfWork
    {
        IAnnouncementRepository Announcement { get; }
        Task SaveAsync();
    }
}
