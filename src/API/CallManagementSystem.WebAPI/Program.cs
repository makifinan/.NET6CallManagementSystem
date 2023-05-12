using CallManagementSystem.Application;
using CallManagementSystem.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddPersistenceServices(builder.Configuration);

builder.Services.AddApplicationServices();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.WithOrigins("http://localhost:3000", "http://localhost:3000", "http://localhost:3001", "https://localhost:3001", "http://localhost:3002", "http://localhost:3002").AllowAnyHeader().AllowAnyMethod().AllowCredentials()
));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();

