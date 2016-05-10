using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects
{
    /// <summary>
    /// Account shared API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public abstract class Account : ComBaseClass
    {
        /// <summary>
        /// Account type
        /// <para>Enum values=(0 - User, 1 - Mailing list, 2 - Executable, 3 - Notification, 4 - Static Route, 5 - Catalog, 6 - List server, 7 - Group, 8 - Resource)</para>
        /// </summary>
        public AccountType? U_Type { get; set; }
        /// <summary>
        /// Account's alias
        /// </summary>
        public string U_Alias { get; set; }
        /// <summary>
        /// Read only list of all account e-mails (i.e. uses also knowledge about domain aliases)
        /// </summary>
        public string U_AliasList { get; protected set; }
        /// <summary>
        /// Account's full name/description
        /// </summary>
        public string U_Name { get; set; }
        /// <summary>
        /// Structure backup [Display only value]
        /// </summary>
        public string U_Backup { get; protected set; }
        /// <summary>
        /// Enable daily mail with daily agenda to user
        /// </summary>
        public bool? U_GW_DailyAgenda { get; set; }
        /// <summary>
        /// Enable email reminders
        /// </summary>
        public bool? U_GW_Reminders { get; set; }
        /// <summary>
        /// Enable automatic creating of revisions when editing documents
        /// </summary>
        public bool? U_GW_AutoRevisionMode { get; set; }

        /// <inheritdoc />
        protected Account()
        {
        }

        /// <inheritdoc />
        protected Account(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
