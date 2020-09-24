using System;
using System.Configuration;

/// <summary>
/// Descripción breve de Connection
/// </summary>
public class Connection
{
    public Connection()
    {
    }

    [Obsolete]
    public static string GetConfigOfAppSettings(string key)
    {
        return ConfigurationSettings.AppSettings.Get(key).ToString();
    }
}