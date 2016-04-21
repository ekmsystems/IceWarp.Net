namespace IceWarpLib.Objects.Com.Enums
{
    public enum DomainType
    {
        Standard = 0,
        EtrnAtrn = 1,
        Alias = 2,
        Backup = 3,
        Distributed = 4
    }

    /// <summary>
    /// User verification mode
    /// </summary>
    public enum DomainVerifyType
    {
        Default = 0,
        IssueRCPT = 1,
        IssueVRFY = 2
    }

    public enum UnknownUsers
    {
        Reject = 0,
        Forward = 1,
        Delete = 2
    }
}
