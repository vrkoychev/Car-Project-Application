using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories.ExtraRepository
{
    public class ExtraRepository : IExtraRepository
    {
        private readonly ApplicationDbContext appDbContext;

        public ExtraRepository(ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Extra> GetAllExtras => appDbContext.Extras.ToList();

        public Extra GetExtraByName(string name) => appDbContext.Extras
            .Include(b => b.CarExtras)
            .AsNoTracking()
            .SingleOrDefault(x => x.Name == name);
    }
}
