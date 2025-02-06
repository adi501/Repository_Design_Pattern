
//Ref: https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/
//https://code-maze.com/net-core-web-development-part4/

using DataAccess.EFCore;
using DataAccess.EFCore.Repositories;
using DataAccess.EFCore.Repositories.GenericRepository;
using DataAccess.EFCore.UnitOfWork;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Start - Register the ApplicationContext class & Cnnection String
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//End - Register the ApplicationContext class & Cnnection String

#region Repositories
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IDeveloperRepository, DeveloperRepository>();
builder.Services.AddTransient<IProjectRepository, ProjectRepository>();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
