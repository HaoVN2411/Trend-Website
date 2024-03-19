using AssignmentSWD.API.Service.Models.Field;
using AssignmentSWD.API.Service.Models.Platform;
using AssignmentSWD.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.API.Service.Interfaces
{
    public interface IFieldService
    {
        public Task<IEnumerable<FieldEntity>> GetAll();
        public Task<FieldEntity> GetById(string id);
        public Task<bool> CreateField(CreateFieldModel model);
        public Task<bool> UpdateField(CreateFieldModel model);
        public Task<bool> DeleteField(string id);
    }
}
