using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Objects.Rpc.Classes.Domain;
using IceWarpLib.Objects.Rpc.Classes.Session;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Fully abstract class , parent of all properties returned in getproperty and similar.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyVal">https://www.icewarp.co.uk/api/#TPropertyVal</see></para>
    /// <para/>Descendants:
    /// <para/><see cref="TAccountCard"/>
    /// <para/><see cref="TAccountImage"/>
    /// <para/><see cref="TAccountName"/>
    /// <para/><see cref="TAccountOutlookPolicies"/>
    /// <para/><see cref="TAccountQuota"/>
    /// <para/><see cref="TAccountResponder"/>
    /// <para/><see cref="TAccountResponderMessage"/>
    /// <para/><see cref="TAccountState"/>
    /// <para/><see cref="TActivationKey"/>
    /// <para/><see cref="TAuthChallenge"/>
    /// <para/><see cref="TDomainOutlookPolicies"/>
    /// <para/><see cref="TIMRoster"/>
    /// <para/><see cref="TOutlookPolicies"/>
    /// <para/><see cref="TPropertyNoValue"/>
    /// <para/><see cref="TPropertyString"/>
    /// <para/><see cref="TPropertyStringList"/>
    /// <para/><see cref="TPropertyMember"/>
    /// <para/><see cref="TPropertyMembers"/>
    /// </summary>
    public abstract class TPropertyVal : RpcBaseClass
    {
        
    }
}
