using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.DataLayer.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IBuildingRepository Buildings { get; }
        IApplicationUserRepository ApplicationUsers { get; }
        Task<int> CompleteAsync();
    }
}

