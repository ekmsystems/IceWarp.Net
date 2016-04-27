using System.Xml;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Outlook policies related to IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAccountOutlookPolicies">https://www.icewarp.co.uk/api/#TAccountOutlookPolicies</see></para>
    /// </summary>
    public class TAccountOutlookPolicies : TOutlookPolicies
    {
        /// <inheritdoc />
        public TAccountOutlookPolicies() : base()
        {
        }

        /// <inheritdoc />
        public TAccountOutlookPolicies(XmlNode node) : base(node)
        {
        }
    }
}
