namespace CarProject
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Repositories.BrandRepository;
    using Repositories.CarExtraRepository;
    using Repositories.CarRepository;
    using Repositories.ExtraRepository;

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

            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IExtraRepository, ExtraRepository>();
            services.AddScoped<ICarExtraRepository, CarExtraRepository>();

            ServiceProvider = services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            ConfigureServices();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new CoreForm());
        }
    }
}