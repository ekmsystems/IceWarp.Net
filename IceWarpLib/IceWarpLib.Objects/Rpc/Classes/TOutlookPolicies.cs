using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Represents class TOutlookPolicies
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
        
        public TOutlookPolicies()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TOutlookPolicies(XmlNode node)
        {
            if (node != null)
            {
                SyncFolderStructure = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("SyncFolderStructure"));
                SyncFolderStructureAfter = Extensions.GetNodeInnerText(node.GetSingleNode("SyncFolderStructureAfter"));
                SyncPriorityFolders = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("SyncPriorityFolders"));
                SyncPriorityFoldersAfter = Extensions.GetNodeInnerText(node.GetSingleNode("SyncPriorityFoldersAfter"));
                SyncStandardFolders = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("SyncStandardFolders"));
                SyncStandardFoldersAfter = Extensions.GetNodeInnerText(node.GetSingleNode("SyncStandardFoldersAfter"));
                SyncFoldersImmediately = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("SyncFoldersImmediately"));
                SyncFoldersImmediatelyValue = Extensions.GetNodeInnerText(node.GetSingleNode("SyncFoldersImmediatelyValue"));
                SyncGAL = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("SyncGAL"));
                SyncGALValue = Extensions.GetNodeInnerText(node.GetSingleNode("SyncGALValue"));
                FolderSyncThreshold = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("FolderSyncThreshold"));
                FolderSyncThresholdMessages = Extensions.GetNodeInnerText(node.GetSingleNode("FolderSyncThresholdMessages"));
                DownloadThreshold = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("DownloadThreshold"));
                DownloadThresholdMB = Extensions.GetNodeInnerText(node.GetSingleNode("DownloadThresholdMB"));
                DownloadFilesFully = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("DownloadFilesFully"));
                DownloadFilesType = Extensions.GetNodeInnerText(node.GetSingleNode("DownloadFilesType"));
                AuthenticationMethod = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("AuthenticationMethod"));
                AuthenticationMethodValue = Extensions.GetNodeInnerText(node.GetSingleNode("AuthenticationMethodValue"));
                LineSecurity = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("LineSecurity"));
                LineSecurityValue = Extensions.GetNodeInnerText(node.GetSingleNode("LineSecurityValue"));
                LoginPort = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("LoginPort"));
                LoginPortValue = Extensions.GetNodeInnerText(node.GetSingleNode("LoginPortValue"));
                DisplayABNames = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("DisplayABNames"));
                DisplayABNamesAs = Extensions.GetNodeInnerText(node.GetSingleNode("DisplayABNamesAs"));
                SaveAsType = Extensions.GetNodeInnerText(node.GetSingleNode("SaveAsType"));
                ResetToDefault = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("ResetToDefault"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "SyncFolderStructure", SyncFolderStructure);
            XmlHelper.AppendTextElement(element, "SyncFolderStructureAfter", SyncFolderStructureAfter);
            XmlHelper.AppendTextElement(element, "SyncPriorityFolders", SyncPriorityFolders);
            XmlHelper.AppendTextElement(element, "SyncPriorityFoldersAfter", SyncPriorityFoldersAfter);
            XmlHelper.AppendTextElement(element, "SyncStandardFolders", SyncStandardFolders);
            XmlHelper.AppendTextElement(element, "SyncStandardFoldersAfter", SyncStandardFoldersAfter);
            XmlHelper.AppendTextElement(element, "SyncFoldersImmediately", SyncFoldersImmediately);
            XmlHelper.AppendTextElement(element, "SyncFoldersImmediatelyValue", SyncFoldersImmediatelyValue);
            XmlHelper.AppendTextElement(element, "SyncGAL", SyncGAL);
            XmlHelper.AppendTextElement(element, "SyncGALValue", SyncGALValue);
            XmlHelper.AppendTextElement(element, "FolderSyncThreshold", FolderSyncThreshold);
            XmlHelper.AppendTextElement(element, "FolderSyncThresholdMessages", FolderSyncThresholdMessages);
            XmlHelper.AppendTextElement(element, "DownloadThreshold", DownloadThreshold);
            XmlHelper.AppendTextElement(element, "DownloadThresholdMB", DownloadThresholdMB);
            XmlHelper.AppendTextElement(element, "DownloadFilesFully", DownloadFilesFully);
            XmlHelper.AppendTextElement(element, "DownloadFilesType", DownloadFilesType);
            XmlHelper.AppendTextElement(element, "AuthenticationMethod", AuthenticationMethod);
            XmlHelper.AppendTextElement(element, "AuthenticationMethodValue", AuthenticationMethodValue);
            XmlHelper.AppendTextElement(element, "LineSecurity", LineSecurity);
            XmlHelper.AppendTextElement(element, "LineSecurityValue", LineSecurityValue);
            XmlHelper.AppendTextElement(element, "LoginPort", LoginPort);
            XmlHelper.AppendTextElement(element, "LoginPortValue", LoginPortValue);
            XmlHelper.AppendTextElement(element, "DisplayABNames", DisplayABNames);
            XmlHelper.AppendTextElement(element, "DisplayABNamesAs", DisplayABNamesAs);
            XmlHelper.AppendTextElement(element, "SaveAsType", SaveAsType);
            XmlHelper.AppendTextElement(element, "ResetToDefault", ResetToDefault);

            return element;
        }
    }
}
