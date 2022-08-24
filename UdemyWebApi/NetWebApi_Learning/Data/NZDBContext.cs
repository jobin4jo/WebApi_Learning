using Microsoft.EntityFrameworkCore;
using NetWebApi_Learning.Model.Domain;

namespace NetWebApi_Learning.Data
{
    public class NZDBContext:DbContext
    {
        public NZDBContext(DbContextOptions<NZDBContext>options):base(options) 
        {

        }
        public DbSet<Region> regions { get; set; }
        public DbSet<Walk> walks { get; set; }
        public DbSet<WalkDifficulty> walkDiffculties { get; set; }
    }
}
