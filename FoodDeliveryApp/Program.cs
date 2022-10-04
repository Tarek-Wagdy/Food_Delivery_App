using FoodDeliveryApp.Models;
using FoodDeliveryApp.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connetionString = builder.Configuration.GetConnectionString("Cs");
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<Entity>(optionsbuilder =>
            {
                optionsbuilder.UseSqlServer(connetionString);
            });
            builder.Services.AddIdentity<ApplicationUser, Role>(
               options => options.Password.RequireDigit = true
               ).
               AddEntityFrameworkStores<Entity>();
            builder.Services.AddScoped<IOrderRepository,OrderRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}