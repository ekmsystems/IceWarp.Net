namespace IceWarpLib.Objects.Com.Enums
{
    public enum UserAuthMode
    {
        Standard = 0,
        NTDomain = 1,
        ActiveDirectory = 2,
        AnyPassword = 3
    }

    public enum MailboxProtocol
    {
        Pop3 = 0,
        ImapAndPop3 = 1,
        Imap = 2
    }

    public enum AccountState
    {
        Enabled = 0,
        DisabledLogin = 1,
        DisabledLoginReceive = 2,
        DisabledTarpitting = 3
    }

    public enum AccountQuarantineReports
    {
        Disabled = 0,
        Default = 1,
        NewItemsOnly = 2,
        AllItems = 3
    }

    public enum AccountSpamFolder
    {
        Default = 0,
        DoNotUse = 1,
        Use = 2
    }

    public enum AutoResponderMode
    {
        DoNotResponse = 0,
        RespondAlways = 1,
        RespondOnce = 2,
        RespondOnceInPeriod = 3
    }
}
