namespace Repositories.CarRepository
{
    using Models;

    public interface ICarRepository
    {
        Car GetCarById(int carId);
        Car GetCarByModel(string model);
        IEnumerable<Car> GetAllCars { get; }
        int Add(Car car);
        void Update(Car car);
        void Delete(int id);
    }
}
