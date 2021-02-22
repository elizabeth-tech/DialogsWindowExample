using Microsoft.Extensions.DependencyInjection;

namespace DialogsWindowExample.Services
{
    internal static class Registrator
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            // Здесь можем регистрировать любые сервисы, которые захотим (может они в будущем появятся)
            return services;
        }
    }
}
