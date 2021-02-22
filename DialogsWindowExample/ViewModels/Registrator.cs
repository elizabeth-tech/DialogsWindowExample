using Microsoft.Extensions.DependencyInjection;

namespace DialogsWindowExample.ViewModels
{
    internal static class Registrator
    {
        // Метод регистрации любых ViewModel
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>(); // модель создается один раз
            services.AddTransient<StudentsManagementViewModel>(); // модель создается каждый раз, когда создается новое окно

            return services;
        }
    }
}
