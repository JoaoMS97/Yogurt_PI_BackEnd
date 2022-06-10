using Yogurt.Application.Interfaces;
using Yogurt.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Yogurt.Application.Interfaces.Comment;
using Yogurt.Application.Interfaces.Publication;
using Yogurt.Application.Interfaces.ReplyComment;
using Yogurt.Application.Services.User;
using Yogurt.Application.Services.Comment;
using Yogurt.Application.Services.Publication;
using Yogurt.Application.Services.ReplyComment;
using Yogurt.Infraestructure.Interfaces.Comment;
using Yogurt.Infraestructure.Interfaces.Publication;
using Yogurt.Infraestructure.Interfaces.ReplyComment;
using Yogurt.Infraestructure.Interfaces.User;
using Yogurt.Infraestructure.Repositories.Comment;
using Yogurt.Infraestructure.Repositories.Publication;
using Yogurt.Infraestructure.Repositories.ReplyComment;
using Yogurt.Infraestructure.Repositories.User;
using Yogurt.Application.Services;
using Yogurt.Infraestructure.Interfaces;
using Yogurt.Infraestructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IFileRepository, FileRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IReplyCommentService, ReplyCommentService>();
builder.Services.AddScoped<IReplyCommentRepository, ReplyCommentRepository>();
builder.Services.AddScoped<IPublicacaoService, PublicacaoService>();
builder.Services.AddScoped<IPublicacaoRepository, PublicacaoRepository>();

builder.Services.AddDbContext<YogurtContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
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
