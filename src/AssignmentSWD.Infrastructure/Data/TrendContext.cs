using AssignmentSWD.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Dynamic;
namespace AssignmentSWD.Infrastructure.Data
{
    public class TrendContext : DbContext
    {
        public TrendContext()
        {
        }

        public TrendContext(DbContextOptions<TrendContext> opt) : base(opt)
        {
        }

        #region
        public DbSet<TrendEntity> trendEntities { get; set; }
        public DbSet<FieldEntity> fieldEntities { get; set; }
        public DbSet<PlatformEntity> platformEntities { get; set; }
        public DbSet<SearchEntity> searchEntities { get; set; }
        public DbSet<TypeEntity> typeEntities { get; set; }
        public DbSet<UserEntity> userEntities { get; set; }
        #endregion


    }
}