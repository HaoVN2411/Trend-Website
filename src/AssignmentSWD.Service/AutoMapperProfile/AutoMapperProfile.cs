using AssignmentSWD.API.Service.Models.Field;
using AssignmentSWD.API.Service.Models.Platform;
using AssignmentSWD.API.Service.Models.Region;
using AssignmentSWD.API.Service.Models.Search;
using AssignmentSWD.Infrastructure.Entities;
using AutoMapper;
using HaoVN.Template_3_layers.Service.Models.Trend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.Service.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Student
            //CreateMap<Student, RequestStudentModel>().ReverseMap();

            //Trend
            CreateMap<TrendEntity, CreateTrendModel>().ReverseMap();
            CreateMap<FieldEntity, CreateFieldModel>().ReverseMap();
            CreateMap<PlatformEntity, CreatePlatformModel>().ReverseMap();
            CreateMap<RegionEntity, CreateRegionModel>().ReverseMap();
            CreateMap<SearchEntity, ResponseSearchModel>().ReverseMap();

        }
    }
}
