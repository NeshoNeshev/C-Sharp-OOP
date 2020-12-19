
using Microsoft.Extensions.DependencyInjection;
using SillyGame.IO;
using SnakeGame.Engine;
using SnakeGame.IO.Contracts;


namespace NetCoreDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IReader, ConsoleReader>()
                .AddSingleton<IWriter,ConsoleWriter>()
                .BuildServiceProvider();

            IWriter writer = serviceProvider.GetService<IWriter>();
            writer.Write("Hey");
        }
    }
}
