using Chill_Practice.Interfaces;
using Chill_Practice.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.IO;

namespace Chill_Practice
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .CreateLogger();

            Log.Logger.Information("Application Starting");

            using var host = Host.CreateDefaultBuilder()
                  .ConfigureServices((context, services) =>
                  {
                      services.AddTransient<IMainService, MainService>();
                      services.AddTransient<ILeetCodeProblems, LeetCodeProblems>();
                  })
                  .UseSerilog()
                  .Build();

            var svc = ActivatorUtilities.CreateInstance<MainService>(host.Services);
            svc.Run();
        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables();
        }
    }
}
