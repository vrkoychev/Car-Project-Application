namespace CarProject
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class StartUp
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-SU6VEL8\\MSSQLSERVER01;Database=CarsDB;Trusted_Connection=True;TrustServerCertificate=True");
            });

            ServiceProvider = services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}