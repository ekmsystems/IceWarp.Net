using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration
{
    public class SystemSettings : ComBaseClass
    {


        /// <inheritdoc />
        public SystemSettings()
        {
        }

        /// <inheritdoc />
        public SystemSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
