using Microsoft.EntityFrameworkCore;
using API_RankHub.Models;
using Microsoft.Extensions.DependencyInjection;



var builder = WebApplication.CreateBuilder(args);





// Add services to the container.

// builder.Services.AddDbContext<UserContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("UsersController")));



builder.Services.AddControllers();



// Database connection Config
var connection = builder.Configuration["ConexaoSqlite:SqliteConnectionString"];

builder.Services.AddDbContext<UserContext>(options =>
    options.UseSqlite(connection));

builder.Services.AddDbContext<RankingContext>(options => 
    options.UseSqlite(connection));
    
builder.Services.AddDbContext<ItemContext>(options =>
    options.UseSqlite(connection));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
