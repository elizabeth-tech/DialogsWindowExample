using Microsoft.Extensions.DependencyInjection;

namespace DialogsWindowExample.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel mainWindowViewModel => App.Host.Services.GetRequiredService<MainWindowViewModel>();
    }
}
