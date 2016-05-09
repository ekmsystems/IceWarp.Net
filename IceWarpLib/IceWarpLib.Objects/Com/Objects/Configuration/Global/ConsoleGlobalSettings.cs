using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Global
{
    /// <summary>
    /// Global Accounts Console Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class ConsoleGlobalSettings : ComBaseClass
    {
        /// <summary>
        /// Number of shown accounts in a domain
        /// </summary>
        public int? C_Accounts_Global_Console_ShowAccounts { get; set; }
        /// <summary>
        /// Database account display start position
        /// </summary>
        public int? C_Accounts_Global_Console_AccountsPosition { get; set; }
        /// <summary>
        /// Domain list display mode
        /// <para>values=(0 - Domain, 1 - Description + Domain, 2 - Domain + Description)</para>
        /// </summary>
        public DomainListDisplay? C_Accounts_Global_Console_DomainDescription { get; set; }
        /// <summary>
        /// Account display mode
        /// </summary>
        public int? C_Accounts_Global_Console_AccountDescription { get; set; }

        /// <inheritdoc />
        public ConsoleGlobalSettings()
        {
        }

        /// <inheritdoc />
        public ConsoleGlobalSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
