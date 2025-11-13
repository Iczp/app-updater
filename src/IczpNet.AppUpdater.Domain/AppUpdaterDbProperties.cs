namespace IczpNet.AppUpdater;

public static class AppUpdaterDbProperties
{
    public static string DbTablePrefix { get; set; } = "AppUpdater";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "AppUpdater";
}
