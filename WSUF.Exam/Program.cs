using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WSUF.Exam;
using WSUF.Exam.Client;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHttpClient();
builder.Services.AddSingleton<Application>();
builder.Services.AddScoped<SolarSystemClient>();
builder.Services.AddScoped<SolarSystemService>();

using IHost host = builder.Build();
using var scope = host.Services.CreateScope();

var app = scope.ServiceProvider.GetRequiredService<Application>();
app.Run();