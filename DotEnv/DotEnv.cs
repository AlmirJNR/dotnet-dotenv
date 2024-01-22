using System.Collections.ObjectModel;

namespace DotEnv;

public static class DotEnv
{
    public static ReadOnlyDictionary<string, string?> LoadConfigurationsFromFile(string filePath)
    {
        if (!File.Exists(filePath))
            return ReadOnlyDictionary<string, string?>.Empty;

        var configurations = new Dictionary<string, string?>();
        foreach (var line in File.ReadAllLines(filePath))
        {
            var parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (parts.Length != 2)
                continue;

            var key = parts[0];
            var value = parts[1];
            configurations.Add(key, value);
        }

        return configurations.AsReadOnly();
    }
}