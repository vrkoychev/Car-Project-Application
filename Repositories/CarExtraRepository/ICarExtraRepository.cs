using Models;

namespace Repositories.CarExtraRepository
{
    public interface ICarExtraRepository
    {
        void Add(CarExtra carExtra);
        ICollection<CarExtra> GetCarExtras(int carId);
    }
}
