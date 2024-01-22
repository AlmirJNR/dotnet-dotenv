using Microsoft.Extensions.Configuration;

namespace DotEnv.Extensions.AspNetCore;

public class DotEnvConfigurationProvider(string filePath) : ConfigurationProvider
{
    public override void Load()
    {
        Data = DotEnv.LoadConfigurationsFromFile(filePath);
    }
}