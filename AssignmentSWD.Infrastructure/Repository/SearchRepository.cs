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
    public class SearchRepository : GenericRepository<SearchEntity>, ISearchRepository
    {
        public SearchRepository(TrendContext context, ILogger logger) : base(context, logger)
        {
            
        }
    }
}
