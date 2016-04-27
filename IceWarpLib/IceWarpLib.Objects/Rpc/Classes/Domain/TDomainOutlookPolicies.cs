using System.Xml;
using IceWarpLib.Objects.Rpc.Classes.Account;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// Outlook policies related to IceWarp domain.
    /// <para><see href="https://www.icewarp.co.uk/api/#TDomainOutlookPolicies">https://www.icewarp.co.uk/api/#TDomainOutlookPolicies</see></para>
    /// </summary>
    public class TDomainOutlookPolicies : TOutlookPolicies
    {
        /// <inheritdoc />
        public TDomainOutlookPolicies() : base()
        {
        }

        /// <inheritdoc />
        public TDomainOutlookPolicies(XmlNode node) : base(node)
        {
        }
    }
}
