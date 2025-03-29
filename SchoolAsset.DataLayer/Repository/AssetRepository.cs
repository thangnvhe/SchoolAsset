using SchoolAsset.DataLayer.Data;
using SchoolAsset.DataLayer.IRepository;
using SchoolAsset.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.Repository
{
    public class AssetRepository : GenericRepository<Asset>, IAssetRepository
    {
        private readonly SchoolAssetDbContext _context;
        public AssetRepository(SchoolAssetDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Asset asset)
        {
           _context.Assets.Update(asset);
        }
    }
}
