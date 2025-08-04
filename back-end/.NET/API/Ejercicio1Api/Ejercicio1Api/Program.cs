using Ejercicio1Api.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// crear la conexion a la base de datos
var connectionString = builder.Configuration.GetConnectionString("Connection");
/*Registrar el servicio para la conexion 
construye el el servicio que conectará con la base de datos, y hazlo usando
SQL Server con la cadena de conexión pasando (connectionString).  */
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString)
    );
    
   // Add services to the container.
// getionalos controladores para responder a las solicitudes http
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); //expone los endpoints de la API
builder.Services.AddSwaggerGen(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); //Redirige de http a https

app.UseAuthorization();

app.MapControllers();

app.Run();
