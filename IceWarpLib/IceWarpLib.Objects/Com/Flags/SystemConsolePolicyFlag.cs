using System;

namespace IceWarpLib.Objects.Com.Flags
{
    [Flags]
    public enum SystemConsolePolicyFlag
    {
        None = 0,
        DisableFileManager = 1,
        DisableDNSTool = 2,
        DisableAPITool = 3,
        DisableSQLManager = 8
    }
}
