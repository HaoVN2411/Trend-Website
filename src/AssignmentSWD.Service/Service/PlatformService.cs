using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Platform;
using AssignmentSWD.Infrastructure.Entities;
using AssignmentSWD.Infrastructure.Interfaces;
using AssignmentSWD.Infrastructure.Repository;
using AutoMapper;

namespace AssignmentSWD.API.Service.Service
{
    public class PlatformService : IPlatformService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PlatformService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PlatformEntity>> GetAll()
        {
            return await _unitOfWork.Platforms.GetAll();
        }

        public async Task<PlatformEntity> GetById(string id)
        {
            return await _unitOfWork.Platforms.GetById(id);
        }

        public async Task<bool> CreatePlatform(CreatePlatformModel model)
        {
            try
            {
                var platformEntity = _mapper.Map<PlatformEntity>(model);
                await _unitOfWork.Platforms.Add(platformEntity);
                await _unitOfWork.CompletedAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdatePlatform(CreatePlatformModel model)
        {
            try
            {
                var platformEntity = _mapper.Map<PlatformEntity>(model);
                await _unitOfWork.Platforms.Update(platformEntity);
                await _unitOfWork.CompletedAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeletePlatform(string id)
        {
            try
            {
                var platform = await _unitOfWork.Platforms.GetById(id);
                if (platform == null)
                {
                    return false;
                }
                await _unitOfWork.Platforms.Remove(platform);
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
