using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWarpLib.Objects.Com.Enums
{
    public enum StaticRouteAction
    {
        ForwardToAddress = 0,
        ForwardToDomain = 1,
        ForwardToHost = 2,
        Delete = 3,
        DeliverToThisDomain = 4
    }

    public enum ExternalFilter
    {
        Filter = 0,
        External = 1,
        All = 2
    }
}
