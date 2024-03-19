using AssignmentSWD.API.Service.Models.Platform;
using AssignmentSWD.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.API.Service.Interfaces
{
    public interface IPlatformService
    {
        public Task<IEnumerable<PlatformEntity>> GetAll();
        public Task<PlatformEntity> GetById(string id);
        public Task<bool> CreatePlatform(CreatePlatformModel model);
        public Task<bool> UpdatePlatform(CreatePlatformModel model);
        public Task<bool> DeletePlatform(string id);
    }
}
