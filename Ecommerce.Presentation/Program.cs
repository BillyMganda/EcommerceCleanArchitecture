using Ecommerce.Application.Brand;
using Ecommerce.Infrastructure;
using Ecommerce.Infrastructure.Brand;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//MINE

builder.Services.AddDbContext<EcommerceDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQLServerConnection")));
builder.Services.AddScoped<IBrandsService, BrandsService>();
builder.Services.AddScoped<IBrandsRepository, BrandsRepository>();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
