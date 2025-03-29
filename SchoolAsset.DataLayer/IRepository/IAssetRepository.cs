using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.DataLayer.IRepository
{
    public interface IAssetRepository : IGenericRepository<Asset>
    {
        void Update(Asset asset);
    }
}
