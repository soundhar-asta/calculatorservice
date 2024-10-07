using CalculatorWebApi.Interfaces;
using CalculatorWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Register CalculatorService with transient scope
builder.Services.AddTransient<ICalculatorService<int>, CalculatorService>();

// Add services for controllers
builder.Services.AddControllers(); // Add this to enable controllers

// Add Swagger services for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Use Swagger middleware to serve the generated OpenAPI specification
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Calculator API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Map controllers to endpoints
app.MapControllers();

app.Run();
