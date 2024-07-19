using System.Reflection;
using MediatR;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddMediatR(m=> m.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
//builder.Services.AddMediatR(m => m.RegisterServicesFromAssembly(typeof(Program).Assembly));

var app = builder.Build();

app.UseStaticFiles();

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();