using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using BakeryAuth.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;

namespace BakeryAuth
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      builder.Services.AddDbContext<BakeryAuthContext>(
        dbContextOptions => dbContextOptions
        .UseMySql(
            builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"])
        )
    );

      builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<BakeryAuthContext>()
            .AddDefaultTokenProviders();

      WebApplication app = builder.Build();

      app.UseDeveloperExceptionPage();

      app.UseStaticFiles();

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthentication(); 
      app.UseAuthorization();

      app.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();
    }
  }
}
