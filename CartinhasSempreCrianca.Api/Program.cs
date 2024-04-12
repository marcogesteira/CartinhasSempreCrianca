using CartinhasSempreCrianca.Repository;
using CartinhasSempreCrianca.Repository.Repository;
using CartinhasSempreCrianca.Application.Cartinha;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CartinhasSempreCriancaContext>(c =>
{
    c.UseSqlServer(builder.Configuration.GetConnectionString("CartinhasConnection"));

});

//Repositories
builder.Services.AddScoped<CartinhaRepository>();

//Services
builder.Services.AddScoped<CartinhaService>();

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