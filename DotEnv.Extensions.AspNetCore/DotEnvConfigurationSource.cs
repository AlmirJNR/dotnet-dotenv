using Microsoft.Extensions.Configuration;

namespace DotEnv.Extensions.AspNetCore;

public class DotEnvConfigurationSource(string filePath) : IConfigurationSource
{
    public IConfigurationProvider Build(IConfigurationBuilder builder)
    {
        return new DotEnvConfigurationProvider(filePath);
    }
}