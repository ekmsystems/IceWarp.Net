using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWarpLib.Objects.Com.Flags
{
    [Flags]
    public enum HeaderFooterFlag
    {
        None = 0,
        HF_L2L = 1,
        HF_L2R = 2,
        HF_R2L = 4,
        HF_R2R = 8
    }
}
