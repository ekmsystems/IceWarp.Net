using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Account -> StaticRoute API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class StaticRoute : Account
    {
        /// <summary>
        /// Alias
        /// </summary>
        public string R_Alias { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string R_Name { get; set; }
        /// <summary>
        /// Action
        /// <para>values=(0 - Forward to address, 1 - Forward to domain, 2 - Forward to host, 3 - Delete, 4 - Deliver to this domain)</para>
        /// </summary>
        public StaticRouteAction? R_Activity { get; set; }
        /// <summary>
        /// Forward
        /// </summary>
        public bool? R_ExternalDomain { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        public string R_ActivityValue { get; set; }
        /// <summary>
        /// Forward to address
        /// </summary>
        public string R_SaveTo { get; set; }//
        /// <summary>
        /// Filter
        /// <para>values=(0 - Filter, 1 - External, 2 - All) </para>
        /// </summary>
        public ExternalFilter? R_ExternalFilter { get; set; }
        /// <summary>
        /// Filter file
        /// </summary>
        public string R_FilterFile { get; set; }
        /// <summary>
        /// External filter file
        /// </summary>
        public string R_ExternalFilterFile { get; set; }
        /// <summary>
        /// External filter type
        /// <para>values=(0 - StdCall library, 1 - Cdecl library, 2 - Executable, 3 - URL)</para>
        /// </summary>
        public ExecutableType? R_ExternalFilterType { get; set; }

        /// <inheritdoc />
        public StaticRoute()
        {
        }

        /// <inheritdoc />
        public StaticRoute(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
