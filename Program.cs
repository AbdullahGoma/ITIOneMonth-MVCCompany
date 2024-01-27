using Microsoft.EntityFrameworkCore;
using ProjectCompany.DpContext;

namespace ProjectCompany
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var ConStr = builder.Configuration.GetConnectionString("SqlCon");


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //builder.Services.AddDbContext<AppDbContext>(Option => Option.UseSqlServer("Data source =ABDULLAH;
            //Database = Second;integrated security = true");

            builder.Services.AddDbContext<AppDbContext>(Option => Option.UseSqlServer(ConStr));


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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

        }
    }
}