using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OrleansHelloWorld
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            IHostBuilder builder = Host.CreateDefaultBuilder(args)
                .UseOrleans(silo =>
                {
                    silo.UseLocalhostClustering()
                        .ConfigureLogging(logging => logging.AddConsole());
                })
                .UseConsoleLifetime();

            using IHost host = builder.Build();

            await host.RunAsync();
        }
    }
}
