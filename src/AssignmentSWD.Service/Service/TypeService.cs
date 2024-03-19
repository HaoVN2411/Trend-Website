using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Type;
using AssignmentSWD.Infrastructure.Entities;
using AssignmentSWD.Infrastructure.Interfaces;
using AutoMapper;

namespace AssignmentSWD.API.Service.Service
{
    public class TypeService : ITypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TypeEntity>> GetAll()
        {
            return await _unitOfWork.Types.GetAll();
        }

        public async Task<TypeEntity> GetById(string id)
        {
            return await _unitOfWork.Types.GetById(id);
        }

        public async Task<bool> CreateType(CreateTypeModel model)
        {
            try
            {
                var typeEntity = _mapper.Map<TypeEntity>(model);
                await _unitOfWork.Types.Add(typeEntity);
                await _unitOfWork.CompletedAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateType(CreateTypeModel model)
        {
            try
            {
                var typeEntity = _mapper.Map<TypeEntity>(model);
                await _unitOfWork.Types.Update(typeEntity);
                await _unitOfWork.CompletedAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteType(string id)
        {
            try
            {
                var type = await _unitOfWork.Types.GetById(id);
                if (type == null)
                {
                    return false;
                }
                await _unitOfWork.Types.Remove(type);
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
