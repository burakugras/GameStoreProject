using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<NorthwindContext>(options => options.UseInMemoryDatabase("nArchitecture"));

            //services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("RentACar")));

            services.AddDbContext<GameStoreDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("EGameStore")));

            services.AddScoped<IGameDal, EfGameDal>();
            services.AddScoped<IGamerDal, EfGamerDal>();
            services.AddScoped<ICampaignDal, EfCampaignDal>();
            return services;
        }
    }
}
