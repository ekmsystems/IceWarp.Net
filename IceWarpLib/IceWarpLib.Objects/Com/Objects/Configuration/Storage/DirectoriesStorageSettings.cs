using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Storage
{
    /// <summary>
    /// Directories Storage Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class DirectoriesStorageSettings : ComBaseClass
    {
        /// <summary>
        /// Path to mail folder
        /// </summary>
        public string C_System_Storage_Dir_MailPath { get; set; }
        /// <summary>
        /// Path to temp folder
        /// </summary>
        public string C_System_Storage_Dir_TempPath { get; set; }
        /// <summary>
        /// Path to log folder
        /// </summary>
        public string C_System_Storage_Dir_LogPath { get; set; }
        /// <summary>
        /// Enables mailbox path alphabetical sorting
        /// </summary>
        public bool? C_System_Storage_Mailbox_UseSorting { get; set; }
        /// <summary>
        /// Number of characters from alias to prefix
        /// </summary>
        public int? C_System_Storage_Mailbox_PrefixLen { get; set; }
        /// <summary>
        /// Number of grouped characters in path prefix
        /// </summary>
        public int? C_System_Storage_Mailbox_GroupedPrefix { get; set; }

        /// <inheritdoc />
        public DirectoriesStorageSettings()
        {
        }

        /// <inheritdoc />
        public DirectoriesStorageSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
