using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Advanced
{
    /// <summary>
    /// Notification Advanced Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class NotificationAdvancedSettings : ComBaseClass
    {
        /// <summary>
        /// Notification messages active
        /// </summary>
        public bool? C_System_Adv_Notification_Active { get; set; }
        /// <summary>
        /// Notification messages host
        /// </summary>
        public string C_System_Adv_Notification_Host { get; set; }

        /// <inheritdoc />
        public NotificationAdvancedSettings()
        {
        }

        /// <inheritdoc />
        public NotificationAdvancedSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
