using ConnectFour.Factories;
using ConnectFour.FrontEnd;
using ConnectFour.Service;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = BuildServiceProvider();
            var app = serviceProvider.GetRequiredService<ConnectFourGame>();

            app.PlayGame();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ConnectFourGame>();
            services.AddSingleton<IConnectFourFrontEnd, ConnectFourFrontEnd>();
            services.AddSingleton<IBoardService, BoardService>();
            services.AddSingleton<IGameService, ConnectFourGameService>();
            services.AddSingleton<ICheckerFactory, CheckerFactory>();
        }
        private static ServiceProvider BuildServiceProvider()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }

    }
}
