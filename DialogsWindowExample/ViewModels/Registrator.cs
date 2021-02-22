using Microsoft.Extensions.DependencyInjection;

namespace DialogsWindowExample.ViewModels
{
    internal static class Registrator
    {
        // Метод регистрации любых ViewModel
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();

            return services;
        }
    }
}
