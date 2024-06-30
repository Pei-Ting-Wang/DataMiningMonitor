using DataMiningMonitor.Forms;
using DataMiningMonitor.Interfaces;
using DataMiningMonitor.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataMiningMonitor
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<MainForm>();
            services.AddScoped<DailyTreadingReport>();
            services.AddScoped<IDailyTreadingReportService, DailyTreadingReportService>();

        }
    }
}