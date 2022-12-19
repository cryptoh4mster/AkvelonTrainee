using Akvelon.DAL.Extensions;
using Akvelon.Business.Extensions;
using Akvelon.WebApi.Extensions;
using Akvelon.WebApi.Middlewares;
using Akvelon.DTO.Mapping;
using Akvelon.Business.Mapping;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

// Add services to the container.
builder.Services.RegisterDataAccess(configuration);
builder.Services.RegisterBusinessServices();
builder.Logging.SetupLogger(configuration);
builder.Services.AddAutoMapper(typeof(ProjectModelMapper), typeof(TaskModelMapper), typeof(ProjectEntityMapper), typeof(TaskEntityMapper)); ;

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

app.UseMiddleware<ExceptionHandler>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
