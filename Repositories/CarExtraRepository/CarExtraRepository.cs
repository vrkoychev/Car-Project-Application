namespace Repositories.CarExtraRepository
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class CarExtraRepository : ICarExtraRepository
    {
        private readonly ApplicationDbContext appDbContext;

        public CarExtraRepository(ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void Add(CarExtra carExtra)
        {
            appDbContext.Entry(carExtra).State = EntityState.Detached;
            appDbContext.CarExtras.Add(carExtra);
            appDbContext.SaveChanges();
        }

        public ICollection<CarExtra> GetCarExtras(int carId) => appDbContext.CarExtras
            .Include(x => x.Car)
            .Include(x => x.Extra)
            .Where(x => x.CarId == carId)
            .ToList();
    }
}
