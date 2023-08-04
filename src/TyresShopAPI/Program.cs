using Microsoft.EntityFrameworkCore;
using TyresShopAPI.Interfaces;
using TyresShopAPI.Persistance;
using TyresShopAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(
       options =>
       {
           options.UseSqlServer(builder.Configuration.GetConnectionString("TyresShopConnection"));
       });

builder.Services.AddScoped<IContext>(provider => provider.GetService<Context>());
builder.Services.AddScoped<ITyresService, TyresService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
