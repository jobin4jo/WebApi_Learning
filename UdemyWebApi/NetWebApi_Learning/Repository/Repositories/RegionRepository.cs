using Microsoft.EntityFrameworkCore;
using NetWebApi_Learning.Data;
using NetWebApi_Learning.Model.Domain;
using NetWebApi_Learning.Repository.IRepository;

namespace NetWebApi_Learning.Repository.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZDBContext _nZDBContext;

        public RegionRepository(NZDBContext nZDBContext)
        {
            this._nZDBContext = nZDBContext;
        }
        public async Task<IEnumerable<Region>>GetAll()
        {
            return await _nZDBContext.regions.ToListAsync();
        }
    }
}
