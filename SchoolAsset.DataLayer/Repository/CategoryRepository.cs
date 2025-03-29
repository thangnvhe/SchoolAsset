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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly SchoolAssetDbContext _context;
        public CategoryRepository(SchoolAssetDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Category category)
        {
           _context.Categories.Update(category);
        }
    }
}
