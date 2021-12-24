using Microsoft.Extensions.DependencyInjection;
using NewsWebApp.BLL.Infrastructure;
using NewsWebApp.BLL.Interfaces;
using NewsWebApp.BLL.Services;
using NewsWebApp.PL.Views;
using System;
using System.Windows.Forms;

namespace NewsWebApp.PL
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
                Application.Run(mainWindow);
            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddRepository("NewsWebDatabase");
            services.AddScoped<MainWindow>();
        }
    }
}
