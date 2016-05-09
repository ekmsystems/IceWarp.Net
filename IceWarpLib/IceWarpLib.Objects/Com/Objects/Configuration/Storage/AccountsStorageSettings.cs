using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Storage
{
    /// <summary>
    /// Accounts Storage Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class AccountsStorageSettings : ComBaseClass
    {
        /// <summary>
        /// Accounts storage mode
        /// </summary>
        public StorageMode? C_System_Storage_Accounts_StorageMode { get; set; }
        /// <summary>
        /// Professional file system memory cache - 10
        /// </summary>
        public int? C_System_Storage_Accounts_ProModeCache { get; set; }
        /// <summary>
        /// ODBC connection string
        /// </summary>
        public string C_System_Storage_Accounts_ODBCConnString { get; set; }
        /// <summary>
        /// Use Multithreaded ODBC
        /// </summary>
        public bool? C_System_Storage_Accounts_ODBCMultithread { get; set; }
        /// <summary>
        /// Max number of parallel connections to DB
        /// </summary>
        public int? C_System_Storage_Accounts_ODBCMaxThreads { get; set; }
        /// <summary>
        /// DB query cache size
        /// </summary>
        public int? C_System_Storage_Accounts_DBCacheCount { get; set; }

        /// <inheritdoc />
        public AccountsStorageSettings()
        {
        }

        /// <inheritdoc />
        public AccountsStorageSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
