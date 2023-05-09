namespace Repositories.CarRepository
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext appDbContext;
        public CarRepository(ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Car> GetAllCars => appDbContext.Cars
            .Include(x => x.Brand)
            .Include(x => x.CarExtras).ThenInclude(x => x.Extra)
            .AsNoTracking().ToList();

        public Car GetCarById(int id) => appDbContext.Cars
            .Include(x => x.Brand)
            .Include(x => x.CarExtras).ThenInclude(x => x.Extra)
            .AsNoTracking().SingleOrDefault(x => x.Id == id);

        public Car GetCarByModel(string model) => appDbContext.Cars
            .Include(x => x.Brand)
            .Include(x => x.CarExtras).ThenInclude(x => x.Extra)
            .AsNoTracking().SingleOrDefault(x => x.Model == model);

        public int Add(Car car)
        {
            appDbContext.Cars.Add(car);
            appDbContext.SaveChanges();

            return car.Id;
        }

        public void Update(Car car)
        {
            var oldCar = appDbContext.Cars.Single(x => x.Id == car.Id);

            oldCar.Model = car.Model;
            oldCar.Year = car.Year;
            oldCar.BrandId = car.BrandId;

            appDbContext.Entry(oldCar).State = EntityState.Modified;
            appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var car = appDbContext.Cars.Find(id);

            appDbContext.Cars.Remove(car);
            appDbContext.SaveChanges();
        }
    }
}
