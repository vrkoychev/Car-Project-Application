namespace Repositories.ExtraRepository
{
    using Models;

    public interface IExtraRepository
    {
        Extra GetExtraByName(string name);
        IEnumerable<Extra> GetAllExtras { get; }
    }
}
 