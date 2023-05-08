namespace Repositories.BrandRepository
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;

    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext appDbContext;

        public BrandRepository(ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Brand> GetAllBrands => appDbContext.Brands
            .Include(x => x.Cars)
            .ToList();

        public Brand GetBrandById(int brandId) => appDbContext.Brands
            .AsNoTracking()
            .SingleOrDefault(x => x.Id == brandId);
    }
}
