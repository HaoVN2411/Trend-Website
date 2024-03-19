using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Service;
using AssignmentSWD.Infrastructure.Interfaces;
using AssignmentSWD.Infrastructure.Repository;
using AssignmentSWD.Service.AutoMapperProfile;
using AutoMapper;

namespace AssignmentSWD.API.Installers
{
    public class ServiceInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMapper>(sp =>
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new AutoMapperProfile());
                });
                return config.CreateMapper();
            });
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ITrendService, TrendService>();
            services.AddTransient<ITypeService, TypeService>();
            services.AddTransient<IPlatformService, PlatformService>();
            services.AddTransient<IFieldService, FieldService>();
            services.AddTransient<IRegionService, RegionService>();
        }
    }
}