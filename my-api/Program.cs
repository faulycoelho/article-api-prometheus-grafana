using Prometheus;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.UseHttpClientMetrics(); 
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMetricServer();
app.UseHttpMetrics();

app.MapGet("/random-number", () =>
{
        var number = Random.Shared.Next(0, 10);
        if (number >= 7)
            return Results.Unauthorized();
        return Results.Ok(number);
});

app.Run();