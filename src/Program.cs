using BugStore.Data;
using BugStore.Handlers.Customers;
using BugStore.Handlers.Products;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddTransient<ICreateCustomerHandler, CreateCustomerHandler>();
builder.Services.AddTransient<IGetCustomerHandler, GetCustomerHandler>();
builder.Services.AddTransient<IGetByIdCustomerHandler, GetByIdCustomerHandler>();
builder.Services.AddTransient<IUpdateCustomerHandler, UpdateCustomerHandler>();
builder.Services.AddTransient<IDeleteCustomerHandler, DeleteCustomerHandler>();
// Products handlers (fully-qualified to avoid ambiguous type names)
builder.Services.AddTransient<ICreateProductHandler, CreateProductHandler>();
builder.Services.AddTransient<IGetProductHandler, GetProductHandler>();
builder.Services.AddTransient<IGetByIdProductHandler, GetByIdProductHandler>();
builder.Services.AddTransient<IUpdateProductHandler, UpdateProductHandler>();
builder.Services.AddTransient<IDeleteProductHandler, DeleteProductHandler>();
var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

// app.MapGet("/v1/customers", () => "Hello World!");
// app.MapGet("/v1/customers/{id}", () => "Hello World!");
// app.MapPost("/v1/customers", () => );
// app.MapPut("/v1/customers/{id}", () => "Hello World!");
// app.MapDelete("/v1/customers/{id}", () => "Hello World!");

// app.MapGet("/v1/products", () => "Hello World!");
// app.MapGet("/v1/products/{id}", () => "Hello World!");
// app.MapPost("/v1/products", () => "Hello World!");
// app.MapPut("/v1/products/{id}", () => "Hello World!");
// app.MapDelete("/v1/products/{id}", () => "Hello World!");

// app.MapGet("/v1/orders/{id}", () => "Hello World!");
// app.MapPost("/v1/orders", () => "Hello World!");

app.Run();
