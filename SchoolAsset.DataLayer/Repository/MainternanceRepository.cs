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
    public class MainternanceRepository : GenericRepository<Maintenance>, IMainternanceRepository
    {
        private readonly SchoolAssetDbContext _context;
        public MainternanceRepository(SchoolAssetDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Maintenance maintenance)
        {
            _context.Maintenances.Update(maintenance);
        }
    }
}
