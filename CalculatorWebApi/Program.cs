var builder = WebApplication.CreateBuilder(args);

// Register CalculatorService with a transient scope
builder.Services.AddTransient(typeof(ICalculatorService<int>), typeof(CalculatorService));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
