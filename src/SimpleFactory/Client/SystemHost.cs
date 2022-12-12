using Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Demos;

namespace Client
{
    public static class SystemHost
    {
        public static async Task StartAsync()
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            var configData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("InputPath", baseDirectory)
            };

            var _configurationRoot = new ConfigurationBuilder()
                .AddInMemoryCollection(configData)
                .Build();

            using IHost host = Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) => services
                    .AddSingleton(_configurationRoot)
                    //.AddSingleton<SimplePizzaFactory>()
                    .AddSingleton<IPizzaFactory, SimplePizzaFactory>()
                    .AddSingleton<ILogger, ConsoleLogger>()
                    .AddSingleton<IDemo, Demo3>())
                .Build();

            var system = host.Services.GetService<IDemo>();

            if (system != null)
                await system.Process();
        }
    }
}
