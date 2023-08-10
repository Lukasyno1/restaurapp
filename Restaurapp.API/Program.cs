using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Restaurapp.API.Middlewares;
using Restaurapp.API.Providers;
using Restaurapp.Application.QueryHandlers.MenuItems;
using Restaurapp.DataAccess;
using Restaurapp.Domain.Providers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    cfg.RegisterServicesFromAssembly(typeof(GetMenuItemsQueryHandler).Assembly);
});

builder.Services.AddDbContext<RContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<ApiKeyMiddleware>();

app.MapControllers();

//run migrations before start
using (var serviceScope = app.Services.GetService<IServiceScopeFactory>()?.CreateScope())
{
    var context = serviceScope?.ServiceProvider.GetRequiredService<RContext>();
    context?.Database.Migrate();
}

    app.Run();
