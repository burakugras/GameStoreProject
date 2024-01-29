using Business.Abstracts;
using Business.Concretes;
using Core.Business;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IGameService, GameManager>();
        services.AddScoped<IGamerService, GamerManager>();
        services.AddScoped<ICampaignService, CampaignManager>();

        services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSubClassesOfType(
       this IServiceCollection services,
       Assembly assembly,
       Type type,
       Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null
   )
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();

        foreach (var item in types)
        {
            if (addWithLifeCycle == null)
            {
                services.AddScoped(item); 
            }
            else
            {
                addWithLifeCycle(services, item);
            }
        }

        return services;
    }
}
