using System.Xml;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Outlook policies related to IceWarp domain
    /// </summary>
    public class TDomainOutlookPolicies : TOutlookPolicies
    {
        public TDomainOutlookPolicies() : base()
        {
        }

        public TDomainOutlookPolicies(XmlNode node) : base(node)
        {
        }
    }
}
