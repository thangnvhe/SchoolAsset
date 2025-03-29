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
    public class BuildingRepository : GenericRepository<Building>, IBuildingRepository
    {
        private readonly SchoolAssetDbContext _context;
        public BuildingRepository(SchoolAssetDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Building building)
        {
            _context.Buildings.Update(building);
        }
    }
}
