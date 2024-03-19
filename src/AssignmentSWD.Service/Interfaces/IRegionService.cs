using AssignmentSWD.API.Service.Models.Region;
using AssignmentSWD.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.API.Service.Interfaces
{
    public interface IRegionService
    {
        public Task<IEnumerable<RegionEntity>> GetAll();
        public Task<RegionEntity> GetById(string id);
        public Task<bool> CreateRegion(CreateRegionModel model);
        public Task<bool> UpdateRegion(CreateRegionModel model);
        public Task<bool> DeleteRegion(string id);
    }
}
