using System.Reflection;
using WebAPI.Services;

namespace WebAPI;

public static class ServiceCollection
{
    public static IServiceCollection AddWebLayer(this IServiceCollection services)
    {
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddTransient<JwtService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}