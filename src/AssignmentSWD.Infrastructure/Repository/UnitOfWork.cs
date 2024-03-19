using AssignmentSWD.Infrastructure.Data;
using AssignmentSWD.Infrastructure.Interfaces;
using AssignmentSWD.Infrastructure.Repository;
using Microsoft.Extensions.Logging;

namespace AssignmentSWD.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TrendContext _context;
        private readonly ILogger _logger;
        public IFieldRepository Fields { get; private set; }
        public IPlatformRepository Platforms { get; private set; }
        public ISearchRepository Searchs { get; private set; }
        public ITrendRepository Trends { get; private set; }
        public IRegionRepository Regions { get; private set; }
        public IUserRepository Users { get; private set; }

        public UnitOfWork(TrendContext context, ILoggerFactory logger)
        {
            _context = context;
            _logger = logger.CreateLogger("logs");

            Fields = new FieldRepository(_context, _logger);
            Platforms = new PlatformRepository(_context, _logger);
            Trends = new TrendRepository(_context, _logger);
            Searchs = new SearchRepository(_context, _logger);
            Regions = new RegionRepository(_context, _logger);
            Users = new UserRepository(_context, _logger);
        }

        public async Task<int> CompletedAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}