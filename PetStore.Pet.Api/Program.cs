using System.Diagnostics;
using System.Linq;
using Lamar.Microsoft.DependencyInjection;
using Microsoft.AspNetCore.Hosting;

namespace PetStore.Pet.Api
{
    public class Program
    {
        public static bool Console = false;

        public static void Main(string[] args)
        {
            if (args.Contains("console") || Debugger.IsAttached)
            {
                Console = true;
            }
            
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseLamar()
                .UseStartup<Startup>()
                .UseUrls("http://*:13001/")
                .Build();
            
            host.Run();
        }
    }
}
