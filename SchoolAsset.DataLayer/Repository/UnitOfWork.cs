﻿using SchoolAsset.DataLayer.Data;
using SchoolAsset.DataLayer.IRepository;
using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.DataLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolAssetDbContext _context;
        public IBuildingRepository Buildings { get; }
        public IApplicationUserRepository ApplicationUsers { get; }
        public IAssetRepository Assets { get; }
        public ICategoryRepository Categories { get; }
        public IMainternanceRepository Mainternances { get; }
        public IRoomRepository Rooms { get; }
        public IRoomTypeRepository RoomTypes { get; }

        public UnitOfWork(SchoolAssetDbContext context)
        {
            _context = context;
            Buildings = new BuildingRepository(_context);
            ApplicationUsers = new ApplicationUserRepository(_context);
            Assets = new AssetRepository(_context);
            Categories = new CategoryRepository(_context);
            Mainternances = new MainternanceRepository(_context);
            Rooms = new RoomRepository(_context);
            RoomTypes = new RoomTypeRepository(_context);
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
