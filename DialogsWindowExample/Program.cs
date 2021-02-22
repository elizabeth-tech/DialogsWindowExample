using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;

namespace DialogsWindowExample
{
    public static class Program
    {
        // Созданная точка входа приложения
        [STAThread]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            // Создаем хост
            var host_builder = Host.CreateDefaultBuilder(args);

            // Настраиваем хост
            host_builder.UseContentRoot(Environment.CurrentDirectory); // Указываем рабочий каталог приложения
            host_builder.ConfigureAppConfiguration((host, cfg) => 
            {
                // cfg - объект конфигурации, host - ссылка на хост
                cfg.SetBasePath(Environment.CurrentDirectory);
                cfg.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); // reloadOnChange - перечитываем, если файл изменился
            });

            host_builder.ConfigureServices(App.ConfigureServices);

            return host_builder;
        }
    }
}
