using Microsoft.Extensions.Configuration;

namespace DotEnv.Extensions.AspNetCore;

public static class DotEnvExtensions
{
    public static void AddConfigurationFromEnvFile(this IConfigurationBuilder builder, string filePath)
    {
        builder.Add(new DotEnvConfigurationSource(filePath));
    }
}