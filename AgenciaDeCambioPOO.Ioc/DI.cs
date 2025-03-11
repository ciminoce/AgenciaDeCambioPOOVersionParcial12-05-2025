using Microsoft.Extensions.DependencyInjection;

namespace AgenciaDeCambioPOO.Ioc
{
    public static class DI
    {
        public static IServiceProvider ConfigurarDI()
        {
            var services = new ServiceCollection();

            //services.AddSingleton<IArchivo, ManejadorArchivoXml>();
            //services.AddSingleton(provider => new RepositorioDivisas(provider.GetRequiredService<IArchivo>(), "NuevasDivisas.xml"));
            //services.AddSingleton<IArchivoSecuencial>(provider => new ManejadorArchivoSecuencial("Transacciones.txt", provider.GetRequiredService<RepositorioDivisas>()));
            //services.AddSingleton(provider => new RepositorioTransacciones(provider.GetRequiredService<IArchivoSecuencial>(),
            //            provider.GetRequiredService<RepositorioDivisas>(), "Transacciones.txt"));
            //services.AddSingleton(provider =>
            //        new AgenciaDeCambio(provider.GetRequiredService<RepositorioDivisas>(),
            //        provider.GetRequiredService<RepositorioTransacciones>()
            //    )
            //   );
            return services.BuildServiceProvider();
        }
    }
}
