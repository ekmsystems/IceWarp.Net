using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.Account
{
    /// <summary>
    /// Uses RPC GetAccountProperties and SetAccountProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetAccountProperties">https://www.icewarp.co.uk/api/#SetAccountProperties</seealso></para>
    /// </summary>
    public abstract class Account
    {
        //Accounts, Shared

        /// <summary>
        /// Account type
        /// </summary>
        public AccountType U_Type { get; set; }
        /// <summary>
        /// Account's alias
        /// </summary>
        public string U_Alias { get; set; }
        /// <summary>
        /// Account's full name/description
        /// </summary>
        public string U_Name { get; set; }
        /// <summary>
        /// Structure backup
        /// </summary>
        public string U_Backup { get; set; }
        /// <summary>
        /// Non user account antispam access
        /// </summary>
        public bool U_NonUserAS { get; set; }
        /// <summary>
        /// Non user account quarantine access
        /// </summary>
        public bool U_NonUserQA { get; set; }
    }
}
