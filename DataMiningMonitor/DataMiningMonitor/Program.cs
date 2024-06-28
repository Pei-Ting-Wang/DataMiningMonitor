using DataMiningMonitor.Forms;
using DataMiningMonitor.Interfaces;
using DataMiningMonitor.Models;
using DataMiningMonitor.Services;
using Microsoft.EntityFrameworkCore;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 從服務提供者中取得主表單實例
            var mainForm = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<Form1>();
            services.AddTransient<DailyTreadingReport>();
            services.AddDbContext<BasicInfoContext>(options =>
                options.UseSqlServer("Data Source=192.168.18.11;Initial Catalog=BasicInfo;User ID=readuser;Password=readuser0404;Trust Server Certificate=True"));
            services.AddScoped<ITestService, TestService>();
            services.AddScoped<IDailyTreadingReportService, DailyTreadingReportService>();

        }
    }
}