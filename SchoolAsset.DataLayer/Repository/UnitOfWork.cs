using SchoolAsset.DataLayer.Data;
using SchoolAsset.DataLayer.IRepository;
using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.DataLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolAssetDbContext _context;
        public IGenericRepository<Building> Buildings { get; }
        public IApplicationUserRepository ApplicationUsers { get; }
        public UnitOfWork(SchoolAssetDbContext context)
        {
            _context = context;
            Buildings = new GenericRepository<Building>(_context);
            ApplicationUsers = new ApplicationUserRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
