using CRM.APPLICATION.Common.Interfaces;
using CRM.INFRASTRUCTURE.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.INFRASTRUCTURE
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<ApplicationDbContext>(options => {

                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

                });


            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

            return services;
        }
    }
    // BU KONFİGÜRASYONU ÖNCE ApplicationDbContext İÇİNDE AÇMIŞTIK. SONRADAN BAŞKA ŞEKİLDE ÖZELLEŞTİRME İHTİYACI DUYARIZ DİYE BU CLASSA TAŞIDIK.
}
