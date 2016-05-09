using System;

namespace IceWarpLib.Objects.Com.Flags
{
    [Flags]
    public enum MailingListDefaultRightsFlag
    {
        RecieveAndPost = 0,
        Recieve = 1,
        Post = 2,
        Digest = 4
    }
}
