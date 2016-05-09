namespace IceWarpLib.Objects.Com.Enums
{
    public enum LogTimeFormat
    {
        SltfTime = 0,
        SltfScientific = 1,
        SltfRFC822 = 2
    }

    public enum LoggingLevel
    {
        None = 0,
        Debug = 1,
        Summary = 2,
        DebugAndSummary = 3,
        Extended = 4
    }

    public enum SqlLogging
    {
        None = 0,
        All = 1,
        FailedOnly = 2,
        SqlConnectionMainenance = 3
    }
}
