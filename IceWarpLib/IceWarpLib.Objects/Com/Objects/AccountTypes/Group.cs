using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Account -> Group API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class Group : Account
    {
        /// <summary>
        /// List file
        /// </summary>
        public string G_ListFile { get; set; }
        /// <summary>
        /// Members file content
        /// </summary>
        public string G_ListFile_Contents { get; set; }
        /// <summary>
        /// Folder name
        /// </summary>
        public string G_Name { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string G_Description { get; set; }
        /// <summary>
        /// Groupware shared
        /// </summary>
        public bool? G_GroupwareShared { get; set; }
        /// <summary>
        /// Groupware members address book
        /// </summary>
        public bool? G_GroupwareMembers { get; set; }
        /// <summary>
        /// Groupware mail delivery
        /// </summary>
        public bool? G_GroupwareMailDelivery { get; set; }
        /// <summary>
        /// Groupware default rights
        /// </summary>
        public string G_GroupwareDefaultRights { get; set; }

        // Message
        /// <summary>
        /// Moderated mode
        /// <para>Enum values=(0 - None, 1 - Client moderated, 2 - Server moderated)</para>
        /// </summary>
        public Moderation? G_Moderated { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string G_ModeratedPassword { get; set; }
        /// <summary>
        /// Max # of messages sent out in 1 minute
        /// </summary>
        public int? G_ListBatch { get; set; }
        /// <summary>
        /// Write only property, adds full ACL rights on root folder
        /// </summary>
        public string G_AddRootAdmin { protected get; set; }

        // Rules
        /// <summary>
        /// Use Rules
        /// </summary>
        public bool? G_BlackWhiteFilter { get; set; }

        // Miscellaneous
        /// <summary>
        /// Spam folder mode
        /// <para>Enum values=(0 - Default, 1 - Do not use Spam folder, 2 - Use Spam folder)</para>
        /// </summary>
        public SpamFolderMode? G_SpamFolder { get; set; }// 
        /// <summary>
        /// Access mode for Anti-Spam
        /// </summary>
        public bool? G_AS { get; set; }
        /// <summary>
        /// Access mode for Quarantine
        /// </summary>
        public bool? G_CR { get; set; }
        /// <summary>
        /// Enables Hierarchic address book
        /// </summary>
        public bool? G_GroupwareHAB { get; set; }
        /// <summary>
        /// If this group is member of another group with enabled HAB, this string is used as the foldername in the HAB
        /// </summary>
        public string G_GroupwareHABFolder { get; set; }
        /// <summary>
        /// Disables GAL distribution list creation
        /// </summary>
        public bool? G_GroupwareDL { get; set; }
        /// <summary>
        /// If this option is ON, members of mailing lists will not be considered as members of the group, and their contacts will not be auto-created in GAL, however, if "Create distribution list" option is ON, there will still be distribution lists autocreated in GAL for all mailing lists that are members of the group
        /// </summary>
        public bool? G_GroupwareGalDontExpandMailingList { get; set; } 
        /// <summary>
        /// Allow export of GAL for other servers within distributed domain
        /// </summary>
        public bool? G_GroupwareAllowGALExport { get; set; } 
        /// <summary>
        /// Deliver externally
        /// </summary>
        public bool? G_DeliverExternally { get; set; }
        /// <summary>
        /// Do not deliver to members with exceeded quotas
        /// </summary>
        public bool? G_CheckMailbox { get; set; }
        /// <summary>
        /// Write only variable , if anything is written there, refresh of the directorycache of this account is scheduled
        /// </summary>
        public bool? G_DirectoryCache_RefreshNow { protected get; set; }

        /// <inheritdoc />
        public Group()
        {
        }

        /// <inheritdoc />
        public Group(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
