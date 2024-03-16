using AssignmentSWD.Infrastructure.Data;
using AssignmentSWD.Infrastructure.Entities;
using AssignmentSWD.Infrastructure.Interfaces;
using HaoVN.Teamplate_3_layers.Infrastructure.Repository;
using Microsoft.Extensions.Logging;

namespace AssignmentSWD.Infrastructure.Repository
{
    public class PlatformRepository : GenericRepository<PlatformEntity>, IPlatformRepository
    {
        public PlatformRepository(TrendContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}