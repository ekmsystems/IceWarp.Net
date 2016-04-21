using System;

namespace IceWarpLib.Objects.Com.Enums
{
    public enum MailingListMembersSource
    {
        ListFile = 0,
        AllCurrentDomainUsers = 1,
        AllSystemUsers = 2,
        AllDomainAdministrators = 3,
        AllSystemAdministrators = 4,
        MembersFromODBC = 5
    }

    public enum MailingListSetSender
    {
        Off = 0,
        SetFrom_ToSender = 1,
        SetReplyTo_ToSender = 2
    }

    public enum MailingListSetValue
    {
        Off = 0,
        SetFrom_ToValue = 1,
        SetReplyTo_ToValue = 2
    }

    public enum MailingListValueMode
    {
        FromHeaderSetToValue = 0,
        ReplyToHeaderSetToValue = 1
    }
    
    public enum MailingListDefaultRights
    {
        ReceiveAndPost = 0,
        ReceiveOnly = 1,
        PostOnly = 2,
        DigestReceiveOnly = 5,
        DigestReceiveAndPost = 7
    }
}
