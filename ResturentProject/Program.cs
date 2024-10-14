
using Resturent.Application.Extensions;
using Resturent.Infrastructure.Extensions;
using Resturent.Infrastructure.Seaders;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAplication();
builder.Services.AddInfrastructure(builder.Configuration);
var app = builder.Build();
var scope=app.Services.CreateScope();
var seeder=scope.ServiceProvider.GetRequiredService<IResturentSeader>();
await seeder.Seed();
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
