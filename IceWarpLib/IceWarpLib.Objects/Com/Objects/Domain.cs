using System.Collections.Generic;
using System.Linq;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Flags;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects
{
    /// <summary>
    /// Uses RPC GetDomainProperties and SetDomainProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetDomainProperties">https://www.icewarp.co.uk/api/#GetDomainProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetDomainProperties">https://www.icewarp.co.uk/api/#SetDomainProperties</seealso></para>
    /// </summary>
    public class Domain : ComBaseClass
    {
        /// <summary>
        /// Domain description
        /// </summary>
        public string D_Description { get; set; }// String ddar=r    
        /// <summary>
        /// Domain Type
        /// </summary>
        public DomainType? D_Type { get; set; }// Enum ddar=r values=(0-Standard domain,1 - ETRN/ATRN queue,2 - Domain Alias,3 - Backup domain,4 - Distributed domain) 
        /// <summary>
        /// Domain Type To value
        /// </summary>
        public string D_DomainValue { get; set; }// String ddar=r    
        /// <summary>
        /// User verification mode
        /// </summary>
        public DomainVerifyType? D_VerifyType { get; set; }// Enum values=(0 - Default, 1 - Issue RCPT, 2 - Issue VRFY, 3 - Minger) 
        /// <summary>
        /// Aliases of the domain defined on the "Aliases" tab
        /// </summary>
        public string D_Aliases { get; set; }// String           
        /// <summary>
        /// Minger Password for this domain
        /// </summary>
        public string D_MingerPassword { get; set; }// String           
        /// <summary>
        /// Default Administrator's alias
        /// </summary>
        public string D_PostMaster { get; set; }// String ddar=r    
        /// <summary>
        /// Administrator's email
        /// </summary>
        public string D_AdminEmail { get; set; }// String ddar=w    
        /// <summary>
        /// Unknown users action
        /// </summary>
        public UnknownUsers? D_UnknownUsersType { get; set; }// Enum ddar=w values=(0 - Reject, 1 - Forward to address, 2 - Delete) 
        /// <summary>
        /// Unknown users Forward to Address
        /// </summary>
        public string D_UnknownForwardTo { get; set; }// String ddar=w    
        /// <summary>
        /// Send information to administrator
        /// </summary>
        public bool? D_InfoToAdmin { get; set; }// Bool             

        // Options
        /// <summary>
        /// Domain Admin account limit
        /// </summary>
        public int? D_AccountNumber { get; set; }// Int ddar=r       
        /// <summary>
        /// Domain disk quota (kB)
        /// </summary>
        public int? D_DiskQuota { get; set; }// Int ddar=r       
        /// <summary>
        /// Disable login to this domain
        /// </summary>
        public bool? D_DisableLogin { get; set; }// Bool ddar=r      
        /// <summary>
        /// User Mailbox size (kB)
        /// </summary>
        public int? D_UserMailbox { get; set; }// Int ddar=w       
        /// <summary>
        /// User send out data limit (MB/day)
        /// </summary>
        public int? D_UserMB { get; set; }// Int ddar=w       
        /// <summary>
        /// User send out messages limit (#/day)
        /// </summary>
        public int? D_UserNumber { get; set; }// Int ddar=w       
        /// <summary>
        /// Notify admin when user send out limit is exceed
        /// </summary>
        public int? D_UserLimitNotify { get; set; }// Int ddar=w       
        /// <summary>
        /// User max message size (kb)
        /// </summary>
        public int? D_UserMsg { get; set; }// Int ddar=w       
        /// <summary>
        /// Enable domain expiration
        /// </summary>
        public bool? D_Expires { get; set; }// Bool ddar=r      
        /// <summary>
        /// Domain Expires On (Number of days from 1899/12/30)
        /// </summary>
        public int? D_ExpiresOn { get; set; }// Int ddar=r       
        /// <summary>
        /// Domain Expires On (Date in yyyy/mm/dd format)
        /// </summary>
        public string D_ExpiresOn_Date { get; set; }// String ddar=r    
        /// <summary>
        /// Enable Notify before expiration
        /// </summary>
        public bool? D_NotifyExpire { get; set; }// Bool ddar=w      
        /// <summary>
        /// Notify before expiration (Days)
        /// </summary>
        public int? D_NotifyBeforeExpires { get; set; }// Int  ddar=w      
        /// <summary>
        /// Delete Expired domains
        /// </summary>
        public bool? D_DeleteExpired { get; set; }// Bool             
        /// <summary>
        /// Limit of emails sent from domain per day
        /// </summary>
        public int? D_NumberLimit { get; set; }// Int ddar=r       
        /// <summary>
        /// Limit of data sent from domain per day
        /// </summary>
        public int? D_VolumeLimit { get; set; }// Int ddar=r       
        /// <summary>
        /// Notify admin when send out limit is exceed
        /// </summary>
        public bool? D_LimitNotify { get; set; }// Bool ddar=r      
        /// <summary>
        /// Domain has AS support [R]
        /// </summary>
        public bool? D_ASSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has Quarantine support [R]
        /// </summary>
        public bool? D_QuarantineSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has AV support [R]
        /// </summary>
        public bool? D_AVSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has IM support [R]
        /// </summary>
        public bool? D_IMSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has SIP support [R]
        /// </summary>
        public bool? D_SIPSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has FTP support [R]
        /// </summary>
        public bool? D_FTPSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has SMS support [R]
        /// </summary>
        public bool? D_SMSSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has GW support [R]
        /// </summary>
        public bool? D_GWSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has WebDAV support [R]
        /// </summary>
        public bool? D_WebDAVSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has ActiveSync support [R]
        /// </summary>
        public bool? D_EASSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has SyncML support [R]
        /// </summary>
        public bool? D_SyncMLSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has Connector support [R]
        /// </summary>
        public bool? D_ConnectorSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has DC support [R]
        /// </summary>
        public bool? D_DesktopSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has Archive support [R]
        /// </summary>
        public bool? D_ArchiveSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Domain has WebMeetings support [R]
        /// </summary>
        public bool? D_MeetingSupport { get; private set; }// Bool ddar=r      
        /// <summary>
        /// Header file
        /// </summary>
        public string D_HeaderFile { get; set; }// String           
        /// <summary>
        /// Header HTML file
        /// </summary>
        public string D_HeaderHTMLFile { get; set; }// String           
        /// <summary>
        /// Footer file
        /// </summary>
        public string D_FooterFile { get; set; }// String           
        /// <summary>
        /// Footer HTML file
        /// </summary>
        public string D_FooterHTMLFile { get; set; }// String           
        /// <summary>
        /// Top Reply  file
        /// </summary>
        public string D_TopTextFile { get; set; }// String           
        /// <summary>
        /// Top Reply HTML file
        /// </summary>
        public string D_TopTextHTMLFile { get; set; }// String           
        /// <summary>
        /// Bit Mask
        /// </summary>
        public HeaderFooterFlag D_HeaderFooterFlag { get; set; }// Int              
        // HF_L2L = $01;
        // HF_L2R = $02;
        // HF_R2L = $04;
        // HF_R2R = $08;

        //Miscellaneous
        /// <summary>
        /// Hostname
        /// </summary>
        public string D_Hostname { get; set; }// String           
        /// <summary>
        /// IP address here to bind the domain to
        /// </summary>
        public string D_IPAddress { get; set; }// String           
        /// <summary>
        /// Folder path
        /// </summary>
        public string D_Folderpath { get; set; }// String           
        /// <summary>
        /// Full path to root of the domain storage, read only, equals to C_System_Storage_Dir_MailPath/Domain name
        /// </summary>
        public string D_BaseMailboxPath { get; set; }// String           
        /// <summary>
        /// Policy - AV
        /// </summary>
        public bool? D_AVScan { get; set; }// Bool             
        /// <summary>
        /// Policy - Antispam
        /// </summary>
        public bool? D_AntiSpam { get; set; }// Bool             
        /// <summary>
        /// Policy - Challenge Response
        /// </summary>
        public bool? D_ChallengeResponse { get; set; }// Bool             
        /// <summary>
        /// Policy - IM
        /// </summary>
        public bool? D_IM { get; set; }// Bool             
        /// <summary>
        /// Policy - GW
        /// </summary>
        public bool? D_Calendar { get; set; }// Bool             
        /// <summary>
        /// Policy - SIP
        /// </summary>
        public bool? D_SIP { get; set; }// Bool             
        /// <summary>
        /// Policy - SyncML
        /// </summary>
        public bool? D_SyncML { get; set; }// Bool             
        /// <summary>
        /// Policy - FTP
        /// </summary>
        public bool? D_FTP { get; set; }// Bool             
        /// <summary>
        /// Policy - SMS
        /// </summary>
        public bool? D_SMS { get; set; }// Bool             
        /// <summary>
        /// Policy - ActiveSync
        /// </summary>
        public bool? D_ActiveSync { get; set; }// Bool             
        /// <summary>
        /// Policy - WebDAV
        /// </summary>
        public bool? D_WebDAV { get; set; }// Bool             
        /// <summary>
        /// Policy - Archive
        /// </summary>
        public bool? D_Archive { get; set; }// Bool             
        /// <summary>
        /// Policy - Outlook Sync
        /// </summary>
        public bool? D_Client_Connector { get; set; }// Bool             
        /// <summary>
        /// Policy - Desktop Client
        /// </summary>
        public bool? D_Client_Desktop { get; set; }// Bool             
        /// <summary>
        /// Structure backup [D]
        /// </summary>
        public string D_Backup { get; private set; }// Longstring       
        /// <summary>
        /// SMS file content [R]
        /// </summary>
        public string D_SMSContent { get; private set; }// Longstring       
        /// <summary>
        /// Domain rules file content in content filter format [D]
        /// </summary>
        public string D_RulesContentXML { get; private set; }// Longstring       
        /// <summary>
        /// Instant Messaging shared roster (Populate with all domain members)
        /// </summary>
        public bool? D_SharedRoster { get; set; }// Bool             
        /// <summary>
        /// Number of SMS sent last month [R]
        /// </summary>
        public int? D_SMS_SentLastMonth { get; private set; }// Int  ddar=r      
        /// <summary>
        /// Number of SMS sent this month [R]
        /// </summary>
        public int? D_SMS_SentThisMonth { get; private set; }// Int  ddar=r      
        /// <summary>
        /// Domain Access mode for meeting
        /// </summary>
        public bool? D_Meeting { get; set; }// Bool             
        /// <summary>
        /// Write only property. Seting a value causes SMTP service to write info about actual account cache into file in temp dirctory
        /// </summary>
        public string D_DumpSMTPAccountCache { get; set; }// String           
        /// <summary>
        /// Domain mailbox size [R]
        /// </summary>
        public int? D_MailboxSize { get; private set; }// Int ddar=r       
        /// <summary>
        /// Write only variable , if anything is written there, refresh of the directorycache of this domain is scheduled
        /// </summary>
        public bool? D_DirectoryCache_RefreshNow { get; set; }// Bool             
        /// <summary>
        /// Status of ABQ
        /// </summary>
        public char? D_ABQStatus { get; set; }// String           
        /// <summary>
        /// Domain level of SMS settings
        /// </summary>
        public string D_SMS_DomainSettings { get; set; }// Longstring       
        /// <summary>
        /// Domain level of FTP settings
        /// </summary>
        public string D_FTP_DomainSettings { get; set; }// Longstring       
        /// <summary>
        /// Override global Anti-Spam thresholds with domain settings
        /// </summary>
        public bool? D_AS_OverrideThresholds { get; set; }// Bool             
        /// <summary>
        /// Enable refusing message when score exceeds D_AS_DeleteScore
        /// </summary>
        public bool? D_AS_SpamAssassinDelete { get; set; }// Bool             
        /// <summary>
        /// Refuse message threshold score
        /// </summary>
        public string D_AS_DeleteScore { get; set; }// String           
        /// <summary>
        /// Enable marking message as spam when score exceeds D_AS_SpamAssassinScoreValue
        /// </summary>
        public bool? D_AS_SpamAssassinScore { get; set; }
        /// <summary>
        /// Spam threshold score
        /// </summary>
        public string D_AS_SpamAssassinScoreValue { get; set; }
        /// <summary>
        /// Quarantine threshold score
        /// </summary>
        public string D_AS_QuarantineScore { get; set; }
        /// <summary>
        /// Enable quarantining message when score exceeds D_AS_QuarantineScore
        /// </summary>
        public bool? D_AS_SpamAssassinQuarantine { get; set; }


        /// <inheritdoc />
        public Domain()
        {
        }

        /// <inheritdoc />
        public Domain(List<TPropertyValue> valueList)
            : base(valueList)
        {
            D_Description = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_Description));
            D_Type = TPropertyValHelper.GetPropertyValAsNullableEnum<DomainType>(valueList, ClassHelper.GetMemberName(() => D_Type));
            D_DomainValue = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_DomainValue));
            D_VerifyType = TPropertyValHelper.GetPropertyValAsNullableEnum<DomainVerifyType>(valueList, ClassHelper.GetMemberName(() => D_VerifyType));
            D_Aliases = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_Aliases));
            D_MingerPassword = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_MingerPassword));
            D_PostMaster = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_PostMaster));
            D_AdminEmail = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_AdminEmail));
            D_UnknownUsersType = TPropertyValHelper.GetPropertyValAsNullableEnum<UnknownUsers>(valueList, ClassHelper.GetMemberName(() => D_UnknownUsersType));
            D_UnknownForwardTo = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_UnknownForwardTo));
            D_InfoToAdmin = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_InfoToAdmin));
            D_AccountNumber = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_AccountNumber));
            D_DiskQuota = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_DiskQuota));
            D_DisableLogin = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_DisableLogin));
            D_UserMailbox = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_UserMailbox));
            D_UserMB = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_UserMB));
            D_UserNumber = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_UserNumber));
            D_UserLimitNotify = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_UserLimitNotify));
            D_UserMsg = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_UserMsg));
            D_Expires = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_Expires));
            D_ExpiresOn = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_ExpiresOn));
            D_ExpiresOn_Date = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_ExpiresOn_Date));
            D_NotifyExpire = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_NotifyExpire));
            D_NotifyBeforeExpires = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_NotifyBeforeExpires));
            D_DeleteExpired = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_DeleteExpired));
            D_NumberLimit = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_NumberLimit));
            D_VolumeLimit = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_VolumeLimit));
            D_LimitNotify = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_LimitNotify));
            D_ASSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_ASSupport));
            D_QuarantineSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_QuarantineSupport));
            D_AVSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_AVSupport));
            D_IMSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_IMSupport));
            D_SIPSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_SIPSupport));
            D_FTPSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_FTPSupport));
            D_SMSSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_SMSSupport));
            D_GWSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_GWSupport));
            D_WebDAVSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_WebDAVSupport));
            D_EASSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_EASSupport));
            D_SyncMLSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_SyncMLSupport));
            D_ConnectorSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_ConnectorSupport));
            D_DesktopSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_DesktopSupport));
            D_ArchiveSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_ArchiveSupport));
            D_MeetingSupport = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_MeetingSupport));
            D_HeaderFile = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_HeaderFile));
            D_HeaderHTMLFile = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_HeaderHTMLFile));
            D_FooterFile = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_FooterFile));
            D_FooterHTMLFile = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_FooterHTMLFile));
            D_TopTextFile = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_TopTextFile));
            D_TopTextHTMLFile = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_TopTextHTMLFile));
            D_HeaderFooterFlag = TPropertyValHelper.GetPropertyValAsEnum<HeaderFooterFlag>(valueList, ClassHelper.GetMemberName(() => D_HeaderFooterFlag));
            D_Hostname = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_Hostname));
            D_IPAddress = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_IPAddress));
            D_Folderpath = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_Folderpath));
            D_BaseMailboxPath = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_BaseMailboxPath));
            D_AVScan = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_AVScan));
            D_AntiSpam = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_AntiSpam));
            D_ChallengeResponse = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_ChallengeResponse));
            D_IM = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_IM));
            D_Calendar = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_Calendar));
            D_SIP = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_SIP));
            D_SyncML = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_SyncML));
            D_FTP = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_FTP));
            D_SMS = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_SMS));
            D_ActiveSync = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_ActiveSync));
            D_WebDAV = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_WebDAV));
            D_Archive = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_Archive));
            D_Client_Connector = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_Client_Connector));
            D_Client_Desktop = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_Client_Desktop));
            D_Backup = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_Backup));
            D_SMSContent = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_SMSContent));
            D_RulesContentXML = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_RulesContentXML));
            D_SharedRoster = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_SharedRoster));
            D_SMS_SentLastMonth = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_SMS_SentLastMonth));
            D_SMS_SentThisMonth = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_SMS_SentThisMonth));
            D_Meeting = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_Meeting));
            D_DumpSMTPAccountCache = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_DumpSMTPAccountCache));
            D_MailboxSize = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, ClassHelper.GetMemberName(() => D_MailboxSize));
            D_DirectoryCache_RefreshNow = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_DirectoryCache_RefreshNow));
            D_ABQStatus = TPropertyValHelper.GetPropertyValAsNullableChar(valueList, ClassHelper.GetMemberName(() => D_ABQStatus));
            D_SMS_DomainSettings = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_SMS_DomainSettings));
            D_FTP_DomainSettings = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_FTP_DomainSettings));
            D_AS_OverrideThresholds = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_AS_OverrideThresholds));
            D_AS_SpamAssassinDelete = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_AS_SpamAssassinDelete));
            D_AS_DeleteScore = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_AS_DeleteScore));
            D_AS_SpamAssassinScore = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_AS_SpamAssassinScore));
            D_AS_SpamAssassinScoreValue = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_AS_SpamAssassinScoreValue));
            D_AS_QuarantineScore = TPropertyValHelper.GetPropertyValAsString(valueList, ClassHelper.GetMemberName(() => D_AS_QuarantineScore));
            D_AS_SpamAssassinQuarantine = TPropertyValHelper.GetPropertyValAsNullableBool(valueList, ClassHelper.GetMemberName(() => D_AS_SpamAssassinQuarantine));
        }
    }
}
