using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.DataLayer.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IBuildingRepository Buildings { get; }
        IApplicationUserRepository ApplicationUsers { get; }
        IAssetRepository Assets { get; }
        ICategoryRepository Categories { get; }
        IMainternanceRepository Mainternances { get; }
        IRoomRepository Rooms { get; }
        IRoomTypeRepository RoomTypes { get; }
        Task<int> CompleteAsync();
    }
}

