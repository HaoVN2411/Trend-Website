using AssignmentSWD.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AssignmentSWD.API.Installers
{
    public class SystemInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddDbContext<TrendContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("TrendDB");
                options.UseSqlServer(connectionString);
            });
        }
    }
}
