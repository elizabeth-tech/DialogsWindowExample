using DialogsWindowExample.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DialogsWindowExample.Services
{
    internal static class Registrator
    {
        // Здесь можем регистрировать любые сервисы
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<StudentsRepository>();
            services.AddSingleton<GroupsRepository>();
            services.AddSingleton<StudentsManager>();
            services.AddTransient<IUserDialogService, WindowsUserDialogService>();

            return services;
        }
    }
}
