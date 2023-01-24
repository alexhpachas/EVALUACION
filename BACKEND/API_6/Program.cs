
using CONEXION.CONEXION;
using CONTRACTS;
using REPOSITORY;
using REPOSITORY.TRABAJADOR;
using CONTRACTS.TRABAJADOR;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<CadenaConexion>(builder.Configuration.GetSection("ConnectionStrings"));
builder.Services.AddScoped<IReportisoryTrabajador, TrabajadorRepository>();


builder.Services.AddCors(options => options.AddPolicy("AllowWebapp",
                                                    builder => builder.AllowAnyOrigin()
                                                                        .AllowAnyHeader()
                                                                        .AllowAnyMethod()));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowWebapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
