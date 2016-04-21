using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.Account
{
    public class Executable
    {
        /// <summary>
        /// Alias
        /// </summary>
        public string E_Alias { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string E_Name { get; set; }
        /// <summary>
        /// Application
        /// </summary>
        public string E_Application { get; set; }
        /// <summary>
        /// Application type
        /// </summary>
        public ExecutableType E_ExecType { get; set; }
        /// <summary>
        /// Application parameters
        /// </summary>
        public string E_Parameters { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string E_ExecPass { get; set; }
        /// <summary>
        /// Forward to address
        /// </summary>
        public string E_ExecForwardCopy { get; set; }
        /// <summary>
        /// Access mode - Antivirus 1
        /// </summary>
        public bool E_AVScan { get; set; }
        /// <summary>
        /// Access mode - Antispam
        /// </summary>
        public bool E_AS { get; set; }
        /// <summary>
        /// Access mode - Quarantine
        /// </summary>
        public bool E_QA { get; set; }

        //Rules

        /// <summary>
        /// Use B&W list
        /// </summary>
        public bool E_BlackWhiteFilter { get; set; }
    }
}
