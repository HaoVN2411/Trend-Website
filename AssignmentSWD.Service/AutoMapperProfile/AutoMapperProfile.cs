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
        }
    }
}
