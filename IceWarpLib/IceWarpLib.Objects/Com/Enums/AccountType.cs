namespace IceWarpLib.Objects.Com.Enums
{
    /// <summary>
    /// Type of the account.
    /// See <see href="https://www.icewarp.co.uk/api/#3.7.TAccountInfo">https://www.icewarp.co.uk/api/#3.7.TAccountInfo</see>
    /// </summary>
    public enum AccountType
    {
        User = 0,
        MailingList = 1,
        Executable = 2,
        Notification = 3,
        StaticRoute = 4,
        Catalog = 5,
        ListServer = 6,
        Group = 7,
        Resource = 8
    }
}
