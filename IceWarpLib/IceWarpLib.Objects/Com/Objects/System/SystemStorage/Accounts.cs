using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System.SystemStorage
{
    public class Accounts
    {
        /// <summary>
        /// Accounts storage mode
        /// </summary>
        public AccountsStorageMode C_System_Storage_Accounts_StorageMode { get; set; }
        /// <summary>
        /// Professional file system memory cache - 10
        /// </summary>
        public int C_System_Storage_Accounts_ProModeCache { get; set; }
        /// <summary>
        /// ODBC connection string
        /// </summary>
        public string C_System_Storage_Accounts_ODBCConnString { get; set; }
        /// <summary>
        /// Use Multithreaded ODBC
        /// </summary>
        public bool C_System_Storage_Accounts_ODBCMultithread { get; set; }

        public int C_System_Storage_Accounts_ODBCMaxThreads { get; set; }
    }
}
