using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects
{
    public class Domain
    {
        //Domain

        /// <summary>
        /// Domain description
        /// </summary>
        public string D_Description { get; set; }
        /// <summary>
        /// Domain Type
        /// </summary>
        public DomainType D_Type { get; set; }
        /// <summary>
        /// Domain Type To value
        /// </summary>
        public string D_DomainValue { get; set; }
        /// <summary>
        /// User verification mode
        /// </summary>
        public DomainVerifyType D_VerifyType { get; set; }
        /// <summary>
        /// Default Administrator's alias
        /// </summary>
        public string D_PostMaster { get; set; }
        /// <summary>
        /// Administrator's email
        /// </summary>
        public string D_AdminEmail { get; set; }
        /// <summary>
        /// Unknown users action
        /// </summary>
        public UnknownUsers D_UnknownUsersType { get; set; }
        /// <summary>
        /// Unknown users Forward to Address
        /// </summary>
        public string D_UnknownForwardTo { get; set; }
        /// <summary>
        /// Send information to administrator
        /// </summary>
        public bool D_InfoToAdmin { get; set; }

        //Limits

        /// <summary>
        /// Domain Admin account limit
        /// </summary>
        public int D_AccountNumber { get; set; }
        /// <summary>
        /// Domain disk quota (kB)
        /// </summary>
        public int D_DiskQuota { get; set; }
        /// <summary>
        /// Limit of data sent from domain per day
        /// </summary>
        public int D_VolumeLimit { get; set; }
        /// <summary>
        /// Limit of emails sent from domain per day
        /// </summary>
        public int D_NumberLimit { get; set; }
        /// <summary>
        /// Disable login to this domain
        /// </summary>
        public bool D_DisableLogin { get; set; }
        /// <summary>
        /// User Mailbox size (kB)
        /// </summary>
        public int D_UserMailbox { get; set; }
        /// <summary>
        /// User max message size (kb)
        /// </summary>
        public int D_UserMsg { get; set; }
        /// <summary>
        /// User send out data limit (MB/day)
        /// </summary>
        public int D_UserMB { get; set; }
        /// <summary>
        /// User send out messages limit (#/day)
        /// </summary>
        public int D_UserNumber { get; set; }
        /// <summary>
        /// Enable domain expiration
        /// </summary>
        public bool D_Expires { get; set; }
        /// <summary>
        /// Domain Expires On (Date)
        /// </summary>
        public int D_ExpiresOn { get; set; }
        /// <summary>
        /// Enable Notify before expiration
        /// </summary>
        public bool D_NotifyExpire { get; set; }
        /// <summary>
        /// Notify before expiration (Days)
        /// </summary>
        public int D_NotifyBeforeExpires { get; set; }
        /// <summary>
        /// Delete Expired domains
        /// </summary>
        public bool D_DeleteExpired { get; set; }

        //Options

        public string D_IPAddress { get; set; }
        /// <summary>
        /// Hostname
        /// </summary>
        public string D_Hostname { get; set; }
        /// <summary>
        /// Folder path
        /// </summary>
        public string D_Folderpath { get; set; }
        /// <summary>
        /// Access mode - AV
        /// </summary>
        public bool D_AVScan { get; set; }
        /// <summary>
        /// Access mode - Antispam
        /// </summary>
        public bool D_AntiSpam { get; set; }
        /// <summary>
        /// Access mode - IM
        /// </summary>
        public bool D_IM { get; set; }
        /// <summary>
        /// Access mode - GW
        /// </summary>
        public bool D_Calendar { get; set; }
        /// <summary>
        /// Access mode - SyncML
        /// </summary>
        public bool D_SyncML { get; set; }
        /// <summary>
        /// Access mode - SIP
        /// </summary>
        public bool D_SIP { get; set; }
        /// <summary>
        /// Access mode - Challenge Response
        /// </summary>
        public bool D_ChallengeResponse { get; set; }
        /// <summary>
        /// Structure backup
        /// </summary>
        public string D_Backup { get; set; }

        public string D_RulesContentXML { get; set; }
    }
}
