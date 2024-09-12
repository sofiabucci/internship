using Microsoft.EntityFrameworkCore;
using ProgrammersProjectLogin.Domain.Interfaces;
using ProgrammersProjectLogin.Infrastructure.Context;
using ProgrammersProjectLogin.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<ILoginRepository, LoginRepository>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddDbContext<ApplicationDataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();