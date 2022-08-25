using NetWebApi_Learning.Model.Domain;

namespace NetWebApi_Learning.Repository.IRepository
{
    public interface IRegionRepository
    {
       Task<IEnumerable<Region>>GetAll();
    }
}
