using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => 
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Tracking Library Identity API",
        Description = "This API is used for authentication process in the Tracking Library system.",
        Contact = new OpenApiContact(){Name = "Abel Pinheiro de Figueiredo", Email = "abelpinheiro95@gmail.com"},
        License = new OpenApiLicense(){Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT")}
    }));

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
