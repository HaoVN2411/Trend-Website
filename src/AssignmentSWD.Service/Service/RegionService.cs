using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Region;
using AssignmentSWD.Infrastructure.Entities;
using AssignmentSWD.Infrastructure.Interfaces;
using AutoMapper;

namespace AssignmentSWD.API.Service.Service
{
    public class RegionService : IRegionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RegionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RegionEntity>> GetAll()
        {
            return await _unitOfWork.Regions.GetAll();
        }

        public async Task<RegionEntity> GetById(string id)
        {
            return await _unitOfWork.Regions.GetById(id);
        }

        public async Task<bool> CreateRegion(CreateRegionModel model)
        {
            try
            {
                var regionEntity = _mapper.Map<RegionEntity>(model);
                await _unitOfWork.Regions.Add(regionEntity);
                await _unitOfWork.CompletedAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateRegion(CreateRegionModel model)
        {
            try
            {
                var regionEntity = _mapper.Map<RegionEntity>(model);
                await _unitOfWork.Regions.Update(regionEntity);
                await _unitOfWork.CompletedAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteRegion(string id)
        {
            try
            {
                var region = await _unitOfWork.Regions.GetById(id);
                if (region == null)
                {
                    return false;
                }
                await _unitOfWork.Regions.Remove(region);
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
