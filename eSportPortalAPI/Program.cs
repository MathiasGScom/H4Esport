using eSportPortalAPI.DB;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = "Server=192.168.91.80;Database=esport_dev;User Id=root;Password=Password1!;";
var serverVersion = new MariaDbServerVersion(new Version(11, 0, 3));

builder.Services.AddDbContext<eSportPortalDbContext>(options =>
{
    options.UseMySql(connectionString, serverVersion).UseMySql(connectionString, serverVersion);                
});

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
