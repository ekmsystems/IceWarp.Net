using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWarpLib.Objects.Com.Enums
{
    public enum LoginBlock
    {
        DoNotBlockButDelayAuthentication = 0,
        BlockAccountForSpecifiedTime = 1
    }

    public enum LoginSetting
    {
        LoginWithUsername = 0,
        LoginWithFullEmailAddress = 1
    }

    public enum AccessGrant
    {
        Deny = 0,
        Grant = 1
    }
}
