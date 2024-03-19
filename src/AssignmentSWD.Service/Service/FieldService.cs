using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Field;
using AssignmentSWD.Infrastructure.Entities;
using AssignmentSWD.Infrastructure.Interfaces;
using AutoMapper;

namespace AssignmentSWD.API.Service.Service
{
    public class FieldService : IFieldService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FieldService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FieldEntity>> GetAll()
        {
            return await _unitOfWork.Fields.GetAll();
        }

        public async Task<FieldEntity> GetById(string id)
        {
            return await _unitOfWork.Fields.GetById(id);
        }

        public async Task<bool> CreateField(CreateFieldModel model)
        {
            try
            {
                var fieldEntity = _mapper.Map<FieldEntity>(model);
                await _unitOfWork.Fields.Add(fieldEntity);
                await _unitOfWork.CompletedAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateField(CreateFieldModel model)
        {
            try
            {
                var fieldEntity = _mapper.Map<FieldEntity>(model);
                await _unitOfWork.Fields.Update(fieldEntity);
                await _unitOfWork.CompletedAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteField(string id)
        {
            try
            {
                var field = await _unitOfWork.Fields.GetById(id);
                if (field == null)
                {
                    return false;
                }
                await _unitOfWork.Fields.Remove(field);
                await _unitOfWork.CompletedAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
