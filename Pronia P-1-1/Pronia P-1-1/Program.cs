using Microsoft.EntityFrameworkCore;
using Pronia_P_1_1.DAL;

namespace Pronia_P_1_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("default"));
            });
           
            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{Action=Index}/{id?}"
                );
            app.UseStaticFiles();
            app.Run();
        }
    }
}
