using AirportFinderCore.Models;
using AirportFinderCore.Repository;
using AirportFinderCore.Services;
using AirportFinderCore.Services.Implementation;
using Microsoft.EntityFrameworkCore;

namespace AirportFinderCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var cons = builder.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
            builder.Services.AddDbContext<DataBaseContext>(x => x.UseSqlServer(cons));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

        
            builder.Services.AddTransient<IRepository<AirportInfo>, Repository<AirportInfo>>();
            builder.Services.AddTransient<IRepository<CityInfo>, Repository<CityInfo>>();
            builder.Services.AddTransient<IRepository<FeedBack>, Repository<FeedBack>>();
            builder.Services.AddTransient<IRepository<StateImg>, Repository<StateImg>>();


            builder.Services.AddTransient<IAirport, AirportService>();
            builder.Services.AddTransient<ICity, CityService>();
            builder.Services.AddTransient<IState, StateService>();
            builder.Services.AddTransient<IFeedBack, FeedBackService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Airport}/{action=Index}/{id?}");

            app.Run();
        }
    }
}