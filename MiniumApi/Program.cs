
using Microsoft.EntityFrameworkCore;
using MiniumApi.Context;
using MiniumApi.Domain;

var builder = WebApplication.CreateBuilder(args);
            
builder.Services.AddDbContext<ApplicationDataContext>(options => options.UseInMemoryDatabase("ProductDB"));
            
var app = builder.Build();
            
app.MapGet("/product", async (ApplicationDataContext db) => 
await db.Product.ToListAsync());

app.MapGet("/product/{id}", async (Guid id, ApplicationDataContext db) =>
await db.Product.FindAsync(id));

app.MapPost("/product", async (Product product, ApplicationDataContext db) => 
{
    db.Product.Add(product); 
    await db.SaveChangesAsync(); 
    return Results.Created("/product", product); 
});

app.MapPut("/product/{id}", async (Guid id, Product productRequest, ApplicationDataContext db) =>
{
    var product = await db.Product.FindAsync(id);

    if (product == null) return Results.NotFound("Non existed product");

    product.Name = productRequest.Name;
    product.Description = productRequest.Description;
    product.Category = productRequest.Category;
    product.Price = productRequest.Price;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/product/{id}", async (Guid id, ApplicationDataContext db) =>
{
    var product = await db.Product.FindAsync(id);

    if (product == null) return Results.NotFound("Non existed product");

    db.Product.Remove(product);

    await db.SaveChangesAsync();

    return Results.NoContent();
});
            
app.UseHttpsRedirection();
            
app.Run();



