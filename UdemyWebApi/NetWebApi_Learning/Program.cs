using Microsoft.EntityFrameworkCore;
using NetWebApi_Learning.Data;
using NetWebApi_Learning.Repository.IRepository;
using NetWebApi_Learning.Repository.Repositories;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<NZDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NzWalks"));
});
// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRegionRepository,RegionRepository>();


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
