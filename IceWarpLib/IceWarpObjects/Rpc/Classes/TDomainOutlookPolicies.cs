using System.Xml;

namespace IceWarpObjects.Rpc.Classes
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
