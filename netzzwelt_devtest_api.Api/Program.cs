using BuberDinner.Api.Filters;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication;
using netzzwelt_devtest_api.Application;
using netzzwelt_devtest_api.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services.AddApplication();
    builder.Services.AddInfrastructure();
     builder.Services.AddControllers();
    // builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(name: "AllowAllOrigin",
          policy =>
          {
              policy.AllowAnyOrigin();
              policy.AllowAnyHeader();
              policy.AllowCredentials();
              policy.AllowAnyMethod();
              policy.WithOrigins("https://localhost:44351", "http://localhost:4200");
          });

        options.AddPolicy(name: "Production",
          policy =>
          {
              policy.AllowAnyHeader();
              policy.AllowAnyMethod();
              policy.WithOrigins("http://localhost:4200");
          });
    });
}

var app = builder.Build();
{

    // Configure the HTTP request pipeline.
   // if (app.Environment.IsDevelopment())
   // {
        //  app.UseMiddleware<ErrorHandlingMiddleware>();


        app.UseCors("AllowAllOrigin");
        app.UseExceptionHandler("/error");
        app.UseHttpsRedirection();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "netzzwelt_devtest_api v1"));
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
   // }



}


