using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Domain.EF.Repositories;
using DAW.Services.Implementations;
using DAW.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAW.WebApi
{
    public static class ServicesExtensionMethods
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration config)
        {
            string connectionString = config["ConnectionStrings:DefaultString"];
            services.AddDbContext<HotelDbContext>(c => c.UseSqlServer(connectionString, b => b.MigrationsAssembly("DAW.WebApi")));
        }

        public static void InjectRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }

        public static void InjectServices(this IServiceCollection services)
        {
            services.AddScoped<IRoomServices, RoomServices>();
            services.AddScoped<IBookingServices, BookingServices>();
            services.AddScoped<IEmployeeServices, EmployeeServices>();
            services.AddScoped<ICustomerServices, CustomerServices>();
        }
    }
}