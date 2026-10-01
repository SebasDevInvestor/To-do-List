using System.Reflection;
using Microsoft.Extensions.DependencyInjection;


namespace To_do_List.Core.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg=>{ }, typeof(MappingProfiles.ProjectMappingProfile).Assembly);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        
        return services;

    }
  
}