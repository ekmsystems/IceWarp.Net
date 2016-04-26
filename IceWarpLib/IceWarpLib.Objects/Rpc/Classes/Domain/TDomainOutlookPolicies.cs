using System.Xml;
using IceWarpLib.Objects.Rpc.Classes.Account;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
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
