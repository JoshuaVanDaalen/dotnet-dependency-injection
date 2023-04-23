using BasicDI;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile($"appsettings.json");

IConfiguration config = builder.Build();

var settings = config.GetSection("AzDevOps").Get<Settings>();

Console.WriteLine($"Azure DevOps endpoint: {settings.BaseUrl}");
