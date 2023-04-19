using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using ParksLookupApi.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ParksLookupApi
{
  class Program
  {
    static void Main(string[] args)
    {
      string localOrigin = "_localOrigin";

      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddCors(options =>
      {
        options.AddDefaultPolicy(
          policy =>
          {
            policy.AllowAnyOrigin()
              .WithMethods("GET");
          });
        options.AddPolicy(name: localOrigin,
          policy =>
          {
            policy.WithOrigins("http://localhost:5000")
              .WithMethods("PUT", "DELETE", "POST");
          });
      });

      builder.Services.AddControllers();

      builder.Services.AddDbContext<ParksLookupApiContext>(
        dbContextOptions => dbContextOptions
            .UseMySql(
              builder.Configuration["ConnectionStrings:DefaultConnection"],
              ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"])
            )
        );

      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();

      WebApplication app = builder.Build();
      app.UseCors();

      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }
      else
      {
        app.UseHttpsRedirection();
      }

      app.MapControllers();

      app.Run();
    }
  }
}
