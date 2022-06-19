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
using Yogurt.Application.Services.Community;
using Microsoft.AspNetCore.Authentication.Certificate;

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

builder.Services.AddScoped<ICommunityService, CommunityService>();
builder.Services.AddScoped<ICommunityRepository, CommunityRepository>();

builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICityRepository, CityRepository>();

builder.Services.AddScoped<IProfileUserService, ProfileUserService>();
builder.Services.AddScoped<IProfileUserRepository, ProfileUserRepository>();

builder.Services.AddScoped<IFriendService, FriendService>();
builder.Services.AddScoped<IFriendRepository, FriendRepository>();

builder.Services.AddDbContext<YogurtContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddAuthentication(
        CertificateAuthenticationDefaults.AuthenticationScheme)
        .AddCertificate();

builder.Services.AddCors(options =>
{
    options.AddPolicy("name",
        builder => builder.AllowAnyOrigin().SetIsOriginAllowed(origin => true).AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("name");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseAuthentication();

app.Run();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
