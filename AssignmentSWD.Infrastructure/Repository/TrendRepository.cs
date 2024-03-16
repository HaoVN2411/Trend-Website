using AssignmentSWD.Infrastructure.Data;
using AssignmentSWD.Infrastructure.Entities;
using AssignmentSWD.Infrastructure.Interfaces;
using HaoVN.Teamplate_3_layers.Infrastructure.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.Infrastructure.Repository
{
    internal class TrendRepository : GenericRepository<TrendEntity>, ITrendRepository
    {
        public TrendRepository(TrendContext context, ILogger logger) : base(context, logger)
        {
            
        }
    }
}
