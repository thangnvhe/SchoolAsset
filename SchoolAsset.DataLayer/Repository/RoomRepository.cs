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
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        private readonly SchoolAssetDbContext _context;
        public RoomRepository(SchoolAssetDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Room room)
        {
            _context.Rooms.Update(room);
        }
    }

}
