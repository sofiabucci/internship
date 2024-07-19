using Microsoft.EntityFrameworkCore;
using Project.Infrastructure.Repositories;
using Project.Infrastructure;
using Project.Domain.Interfaces.IProduct;
using Project.Domain.Interfaces.ICategory;
using Project.Domain.Interfaces.IBrand;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddInfraService(builder.Configuration);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseStaticFiles();

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();