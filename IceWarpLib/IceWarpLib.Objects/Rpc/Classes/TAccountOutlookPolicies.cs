using System.Xml;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Outlook policies related to IceWarp account
    /// </summary>
    public class TAccountOutlookPolicies : TOutlookPolicies
    {
        public TAccountOutlookPolicies() : base()
        {
        }

        public TAccountOutlookPolicies(XmlNode node) : base(node)
        {
        }
    }
}
