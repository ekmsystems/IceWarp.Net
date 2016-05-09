using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Account -> Resource API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class Resource : Account
    {
        /// <summary>
        /// Type of resource
        /// <para>values=(rtRoom, rtEquipment,rtCar)</para>
        /// </summary>
        public ResourceType? S_Type { get; set; }
        /// <summary>
        /// Resource temporarily unavailable
        /// </summary>
        public bool? S_Unavailable { get; set; }
        /// <summary>
        /// Manager email
        /// </summary>
        public string S_Manager { get; set; }
        /// <summary>
        /// Allow requests overlapping
        /// </summary>
        public bool? S_AllowConflicts { get; set; }
        /// <summary>
        /// File with organizers
        /// </summary>
        public string S_OrganizersFile { get; set; }
        /// <summary>
        /// Organizers file contents
        /// </summary>
        public string S_OrganizersFile_Contents { get; set; }
        /// <summary>
        /// Send notification to S_Manager
        /// </summary>
        public bool? S_NotificationToManager { get; set; }

        /// <inheritdoc />
        public Resource()
        {
        }

        /// <inheritdoc />
        public Resource(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
