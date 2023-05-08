using Models;

namespace Repositories.BrandRepository
{
    public interface IBrandRepository
    {
        Brand GetBrandById(int brandId);
        IEnumerable<Brand> GetAllBrands { get; }
    }
}
