using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Advanced
{
    public class AdvancedSettings : ComBaseClass
    {
        /// <summary>
        /// Write Only - Renames default folders, accepts URL-encoded, UTF-8 list of form
        /// <para>Accepts URL-encoded, UTF-8 list where=value1&events=value2&contacts=value3&tasks=value4&notes=value5&journals=value6&files=value7&drafts=value8&trash=value9&sent=value10</para>
        /// <example>use e.g. tool set system C_System_Adv_Rename_Default_Folders "where=*&sent=Odeslan"</example>
        /// </summary>
        public string C_System_Adv_Rename_Default_Folders { protected get; set; }
        /// <summary>
        /// Write Only - Sends signal to all servicess to process the new day procedures
        /// </summary>
        public bool? C_System_Adv_Process_New_Day { protected get; set; }
        /// <summary>
        /// Linux only - if set, SIGSEGV and others will terminate affected service instead of throwing exception
        /// </summary>
        public bool? C_System_Adv_Exit_On_Signal { get; set; }
        /// <summary>
        /// Write Only - Sends signal to GW servicess to process the GAL synchronization
        /// </summary>
        public bool? C_System_Adv_Plan_GAL_Resync { protected get; set; }

        /// <inheritdoc />
        public AdvancedSettings()
        {
        }

        /// <inheritdoc />
        public AdvancedSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
