using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Represents class TOutlookPolicies.
    /// <para><see href="https://www.icewarp.co.uk/api/#TOutlookPolicies">https://www.icewarp.co.uk/api/#TOutlookPolicies</see></para>
    /// </summary>
    public class TOutlookPolicies : TPropertyVal
    {
        /// <summary>
        /// Sync folder structure
        /// </summary>
        public bool SyncFolderStructure { get; set; }
        /// <summary>
        /// Sync folder structure after N minutes
        /// </summary>
        public string SyncFolderStructureAfter { get; set; }
        /// <summary>
        /// Synchronize priority folders
        /// </summary>
        public bool SyncPriorityFolders { get; set; }
        /// <summary>
        /// Synchronize priority folders after N minutes
        /// </summary>
        public string SyncPriorityFoldersAfter { get; set; }
        /// <summary>
        /// Synchronize standard folders
        /// </summary>
        public bool SyncStandardFolders { get; set; }
        /// <summary>
        /// Synchronize standard folders after N minutes
        /// </summary>
        public string SyncStandardFoldersAfter { get; set; }
        /// <summary>
        /// Synchronize folder immediately after change is detected
        /// </summary>
        public bool SyncFoldersImmediately { get; set; }
        /// <summary>
        /// Synchronize folder immediately after change is detected value
        /// </summary>
        public string SyncFoldersImmediatelyValue { get; set; }
        /// <summary>
        /// Sync Global address list
        /// </summary>
        public bool SyncGAL { get; set; }
        /// <summary>
        /// Sync Global address list value
        /// </summary>
        public string SyncGALValue { get; set; }
        /// <summary>
        /// Folder synchronization threshold
        /// </summary>
        public bool FolderSyncThreshold { get; set; }
        /// <summary>
        /// Folder synchronization threshold value ( messages in folder )
        /// </summary>
        public string FolderSyncThresholdMessages { get; set; }
        /// <summary>
        /// Download threshold
        /// </summary>
        public bool DownloadThreshold { get; set; }
        /// <summary>
        /// Download threshold value in MB
        /// </summary>
        public string DownloadThresholdMB { get; set; }
        /// <summary>
        /// Download files fully
        /// </summary>
        public bool DownloadFilesFully { get; set; }
        /// <summary>
        /// Download files type (custom, headers, full)
        /// </summary>
        public string DownloadFilesType { get; set; }
        /// <summary>
        /// Authentication method
        /// </summary>
        public bool AuthenticationMethod { get; set; }
        /// <summary>
        /// Authentication method value (CRAM MD5, Plain)
        /// </summary>
        public string AuthenticationMethodValue { get; set; }
        /// <summary>
        /// Line Security
        /// </summary>
        public bool LineSecurity { get; set; }
        /// <summary>
        /// Line Security value (plain, starttls, ssl)
        /// </summary>
        public string LineSecurityValue { get; set; }
        /// <summary>
        /// Login port
        /// </summary>
        public bool LoginPort { get; set; }
        /// <summary>
        /// Login port value
        /// </summary>
        public string LoginPortValue { get; set; }
        /// <summary>
        /// Display Address book names
        /// </summary>
        public bool DisplayABNames { get; set; }
        /// <summary>
        /// Display Address book value ( numbered structure, folder name only, full folder path , outlook native )
        /// </summary>
        public string DisplayABNamesAs { get; set; }
        /// <summary>
        /// Save as type (default, force settings)
        /// </summary>
        public string SaveAsType { get; set; }
        /// <summary>
        /// Reset to default indicator
        /// </summary>
        public bool ResetToDefault { get; set; }

        /// <inheritdoc />
        public TOutlookPolicies()
        {
        }

        /// <inheritdoc />
        public TOutlookPolicies(XmlNode node)
        {
            if (node != null)
            {
                SyncFolderStructure = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => SyncFolderStructure)));
                SyncFolderStructureAfter = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => SyncFolderStructureAfter)));
                SyncPriorityFolders = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => SyncPriorityFolders)));
                SyncPriorityFoldersAfter = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => SyncPriorityFoldersAfter)));
                SyncStandardFolders = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => SyncStandardFolders)));
                SyncStandardFoldersAfter = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => SyncStandardFoldersAfter)));
                SyncFoldersImmediately = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => SyncFoldersImmediately)));
                SyncFoldersImmediatelyValue = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => SyncFoldersImmediatelyValue)));
                SyncGAL = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => SyncGAL)));
                SyncGALValue = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => SyncGALValue)));
                FolderSyncThreshold = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => FolderSyncThreshold)));
                FolderSyncThresholdMessages = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => FolderSyncThresholdMessages)));
                DownloadThreshold = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => DownloadThreshold)));
                DownloadThresholdMB = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => DownloadThresholdMB)));
                DownloadFilesFully = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => DownloadFilesFully)));
                DownloadFilesType = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => DownloadFilesType)));
                AuthenticationMethod = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => AuthenticationMethod)));
                AuthenticationMethodValue = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => AuthenticationMethodValue)));
                LineSecurity = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => LineSecurity)));
                LineSecurityValue = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => LineSecurityValue)));
                LoginPort = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => LoginPort)));
                LoginPortValue = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => LoginPortValue)));
                DisplayABNames = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => DisplayABNames)));
                DisplayABNamesAs = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => DisplayABNamesAs)));
                SaveAsType = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => SaveAsType)));
                ResetToDefault = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => ResetToDefault)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SyncFolderStructure), SyncFolderStructure);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SyncFolderStructureAfter), SyncFolderStructureAfter);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SyncPriorityFolders), SyncPriorityFolders);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SyncPriorityFoldersAfter), SyncPriorityFoldersAfter);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SyncStandardFolders), SyncStandardFolders);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SyncStandardFoldersAfter), SyncStandardFoldersAfter);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SyncFoldersImmediately), SyncFoldersImmediately);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SyncFoldersImmediatelyValue), SyncFoldersImmediatelyValue);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SyncGAL), SyncGAL);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SyncGALValue), SyncGALValue);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => FolderSyncThreshold), FolderSyncThreshold);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => FolderSyncThresholdMessages), FolderSyncThresholdMessages);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DownloadThreshold), DownloadThreshold);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DownloadThresholdMB), DownloadThresholdMB);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DownloadFilesFully), DownloadFilesFully);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DownloadFilesType), DownloadFilesType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => AuthenticationMethod), AuthenticationMethod);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => AuthenticationMethodValue), AuthenticationMethodValue);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => LineSecurity), LineSecurity);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => LineSecurityValue), LineSecurityValue);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => LoginPort), LoginPort);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => LoginPortValue), LoginPortValue);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DisplayABNames), DisplayABNames);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DisplayABNamesAs), DisplayABNamesAs);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SaveAsType), SaveAsType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ResetToDefault), ResetToDefault);

            return element;
        }
    }
}
