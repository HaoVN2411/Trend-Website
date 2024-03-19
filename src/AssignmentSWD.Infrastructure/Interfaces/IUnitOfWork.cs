using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IFieldRepository Fields { get; }
        IPlatformRepository Platforms { get; }
        ISearchRepository Searchs { get; }
        ITrendRepository Trends { get; }
        IRegionRepository Regions { get; }
        IUserRepository Users { get; }
        Task<int> CompletedAsync();
    }
}
