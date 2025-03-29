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
    public class RoomTypeRepository : GenericRepository<RoomType>, IRoomTypeRepository
    {
        private readonly SchoolAssetDbContext _context;
        public RoomTypeRepository(SchoolAssetDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(RoomType roomType)
        {
            _context.RoomTypes.Update(roomType);
        }

    }
}
