using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Global
{
    /// <summary>
    /// Global Accounts Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class AccountsGlobalSettings : ComBaseClass
    {
        /// <summary>
        /// Enable User statistics
        /// </summary>
        public bool? C_Accounts_Global_Accounts_UserStat { get; set; }
        /// <summary>
        /// Use Account defaults
        /// </summary>
        public bool? C_Accounts_Global_Accounts_UseDefaults { get; set; }
        /// <summary>
        /// Disables account caching
        /// </summary>
        public bool? C_Accounts_Global_Accounts_DisableCache { get; set; }
        /// <summary>
        /// Maximal number of cached items per domain. Domains wirh less than this number accounts will cache every account. Greater domains will check only recently accessed accounts (such cache can not be used for looping over all domain members)
        /// </summary>
        public int? C_Accounts_Global_Accounts_AccountCache { get; set; }
        /// <summary>
        /// Disables database journal tracking changes in accounts , the journal is used for faster update of account cache - only changed accounts are updated
        /// </summary>
        public bool? C_Accounts_Global_Accounts_Disable_Account_Change_Journal { get; set; }
        /// <summary>
        /// number of miliseconds to wait after wave processes WaveSafecount items, default = 0, which means automated sophisticated choice
        /// </summary>
        public int? C_Accounts_Global_Accounts_DirectoryCacheWaveSleep { get; set; }
        /// <summary>
        /// number of items to process before waiting, default = 0, which means automated sophisticated choice
        /// </summary>
        public int? C_Accounts_Global_Accounts_DirectoryCacheWaveSafeCount { get; set; }
        /// <summary>
        /// Connection string to directory cache database
        /// </summary>
        public string C_Accounts_Global_Accounts_DirectoryCacheConnectionString { get; set; }
        /// <summary>
        /// Schedule data for directorycache
        /// </summary>
        public string C_Accounts_Global_Accounts_DirectoryCacheSchedule { get; set; }//TODO - figure out what gets returned - Schedule
        /// <summary>
        /// If set to true, the only one quaery against the directory cache is done at a time  (changing requires restart of all services)
        /// </summary>
        public bool? C_Accounts_Global_Accounts_DirectoryCacheExclusiveLocking { get; set; }
        /// <summary>
        /// Write only variable , if anything is written there, full refresh of the directorycache is scheduled
        /// </summary>
        public bool? C_Accounts_Global_Accounts_DirectoryCache_RefreshNow { protected get; set; }
        /// <summary>
        /// If set to true, wave mode processing is interupted and no new wave is started unless this variable is set to false again
        /// </summary>
        public bool? C_Accounts_Global_Accounts_DirectoryCache_WaveStopped { get; set; }
        /// <summary>
        /// Maintenance logging level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary, 4 - Extended)</para>
        /// </summary>
        public LoggingLevel? C_Accounts_Global_Accounts_MaintenanceLog { get; set; }
        /// <summary>
        /// Auth logging level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary, 4 - Extended)</para>
        /// </summary>
        public LoggingLevel? C_Accounts_Global_Accounts_AuthLog { get; set; }
        /// <summary>
        /// Delivery reports
        /// </summary>
        public bool? C_Accounts_Global_Accounts_DeliveryReports { get; set; }
        /// <summary>
        /// Delete delivery report files older then given number of days
        /// </summary>
        public int? C_Accounts_Global_Accounts_DeliveryReportsDeleteOlder { get; set; }
        /// <summary>
        /// enables distributed domains accounts caching
        /// </summary>
        public bool? C_Accounts_Global_Distributed_Accounts_Cache_Enabled { get; set; }
        /// <summary>
        /// Maximal Number of cached items
        /// </summary>
        public int? C_Accounts_Global_Distributed_Accounts_Cache_Max { get; set; }
        /// <summary>
        /// cache expiration in seconds
        /// </summary>
        public int? C_Accounts_Global_Distributed_Accounts_CacheExpire { get; set; }
        /// <summary>
        /// One char only, a default character replacing spaces in alias
        /// </summary>
        public char? C_Accounts_Global_SpaceReplaceChar { get; set; }
        /// <summary>
        /// Minutes interval
        /// </summary>
        public int? C_Accounts_Global_ActiveDirectorySyncInterval { get; set; }
        
        /// <inheritdoc />
        public AccountsGlobalSettings()
        {
        }

        /// <inheritdoc />
        public AccountsGlobalSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
