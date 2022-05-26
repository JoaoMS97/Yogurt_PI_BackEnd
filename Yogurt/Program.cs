using Yogurt.Application.Interfaces;
using Yogurt.Application.Services;
using Yogurt.Infraestructure.Context;
using Yogurt.Infraestructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Yogurt.Infraestructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddDbContext<YogurtContext>(options =>
{
    options.UseSqlite("Data Source=C:\\Users\\leo-b\\yogurt-dbCadastroUsuarioProjeto.db");
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
