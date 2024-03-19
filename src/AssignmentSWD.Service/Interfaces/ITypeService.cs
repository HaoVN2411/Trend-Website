using AssignmentSWD.API.Service.Models.Platform;
using AssignmentSWD.API.Service.Models.Type;
using AssignmentSWD.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.API.Service.Interfaces
{
    public interface ITypeService
    {
        public Task<IEnumerable<TypeEntity>> GetAll();
        public Task<TypeEntity> GetById(string id);
        public Task<bool> CreateType(CreateTypeModel model);
        public Task<bool> UpdateType(CreateTypeModel model);
        public Task<bool> DeleteType(string id);
    }
}
