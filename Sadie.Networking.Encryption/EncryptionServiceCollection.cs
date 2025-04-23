using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sadie.Options.Options;

namespace Sadie.Networking.Encryption;

public static class EncryptionServiceCollection
{
    public static void AddServices(IServiceCollection serviceCollection, IConfiguration config)
    {
        serviceCollection.AddSingleton<HabboEncryption>();
        serviceCollection.Configure<EncryptionOptions>(options => config.GetSection("Encryption").Bind(options));
    }
}
