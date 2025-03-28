using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.DataLayer.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Building> Buildings { get; }
        Task<int> CompleteAsync();
    }
}

