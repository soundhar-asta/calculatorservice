using CalculatorWebApi.Interfaces;
using CalculatorWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICalculatorService<int>, CalculatorService>();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Calculator API V1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
