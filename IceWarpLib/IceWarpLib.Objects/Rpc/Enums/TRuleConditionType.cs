namespace IceWarpLib.Objects.Rpc.Enums
{
    /// <summary>
    /// Conditions
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleConditionType">https://www.icewarp.co.uk/api/#TRuleConditionType</see></para>
    /// </summary>
    public enum TRuleConditionType
    {
        None = 0,
        From = 1,
        To = 2,
        Subject = 3,
        CC = 4,
        ReplyTo = 5,
        Bcc = 6,
        Date = 7,
        Priority = 8,
        Spam = 9,
        Size = 10,
        Body = 11,
        CustomHeader = 12,
        AnyHeader = 13,
        AttachName = 14,
        StripAttach = 15,
        RenameAttach = 16,
        HasAttach = 17,
        Charset = 18,
        Sender = 19,
        Recipient = 20,
        SenderRecipient = 21,
        RemoteHost = 22,
        RFC822 = 23,
        Execution = 24,
        RemoteIP = 25,
        RDNS = 26,
        DNSBL = 27,
        TrustedSession = 28,
        SpamScore = 29,
        BayesSize = 30,
        SMTPAuth = 31,
        Antivirus = 32,
        Time = 33,
        SQL = 34,
        All = 35,
        Age = 36,
        Folder = 37,
        Owner = 38
    }
}
