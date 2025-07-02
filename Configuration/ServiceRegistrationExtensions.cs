using ExportExcel.Infrastructure.Configuration;

namespace ExportExcel.Configuration;

public static class ServiceRegistrationExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddHttpContextAccessor();
        services.AddInfrastructureServices(configuration);
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers();

        return services;
    }
}