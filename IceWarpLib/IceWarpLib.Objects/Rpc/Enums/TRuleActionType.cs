namespace IceWarpLib.Objects.Rpc.Enums
{
    /// <summary>
    /// Represents enumeration TRuleActionType
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleActionType">https://www.icewarp.co.uk/api/#TRuleActionType</see></para>
    /// </summary>
    public enum TRuleActionType
    {
        None = 0,
        SendMessage = 1,
        Forward = 2,
        CopyMessage = 3,
        MoveFolder = 4,
        CopyFolder = 5,
        Encrypt = 6,
        Priority = 7,
        Respond = 8,
        Flags = 9,
        Header = 10,
        Score = 11,
        Execute = 12,
        HeaderFooter = 13,
        StripAll = 14,
        Exctract = 15,
        SmartAttach = 16,
        Append = 17,
        SMTPResponse = 18,
        FixRFC822 = 19,
        TarpitIP = 20,
        DB = 21,
        SkipArchive = 22,
        MoveToArchive = 23,
        CopyToArchive = 24,
        MessageAction = 25,
        DeleteMessage = 26,
        Stop = 27
    }
}
