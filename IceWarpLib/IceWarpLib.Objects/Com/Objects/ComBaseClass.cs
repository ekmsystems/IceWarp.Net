using System.Collections.Generic;
using System.Reflection;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects
{
    /// <summary>
    /// Base class for an IceWarp API COM Object
    /// </summary>
    public abstract class ComBaseClass
    {
        /// <summary>
        /// Returns a list of public property names.
        /// </summary>
        /// <returns>The public property names.</returns>
        public List<string> PropertyNames()
        {
            return ClassHelper.GetPropertyNames(this.GetType(), BindingFlags.Instance | BindingFlags.Public);
        }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        protected ComBaseClass() { }

        /// <summary>
        /// Creates a new instance from a list of TPropertyValue. See <see cref="TPropertyValue"/> for more information.
        /// </summary>
        /// <param name="valueList">A list of property values. <see cref="List{TPropertyValue}"/></param>
        protected ComBaseClass(List<TPropertyValue> valueList) { }
    }
}
