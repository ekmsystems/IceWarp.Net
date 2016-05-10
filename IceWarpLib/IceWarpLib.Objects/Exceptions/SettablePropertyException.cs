using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWarpLib.Objects.Exceptions
{
    public class SettablePropertyException : Exception
    {
        public string PropertyName { get; set; }

        public SettablePropertyException(string propertyName) : base(String.Format("{0} is not a public property.", propertyName))
        {
            PropertyName = propertyName;
        }
    }
}
