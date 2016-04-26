using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Objects.Rpc.Classes.Domain;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Fully abstract class , parent of all properties returned in getproperty and similar.
    /// Descendants:
    ///  - <see cref="TAccountCard"/>
    ///  - <see cref="TAccountImage"/>
    ///  - <see cref="TAccountName"/>
    ///  - <see cref="TAccountOutlookPolicies"/>
    ///  - <see cref="TAccountQuota"/>
    ///  - <see cref="TAccountResponder"/>
    ///  - <see cref="TAccountResponderMessage"/>
    ///  - <see cref="TAccountState"/>
    ///  - <see cref="TActivationKey"/>
    ///  - <see cref="TAuthChallenge"/>
    ///  - <see cref="TDomainOutlookPolicies"/>
    ///  - <see cref="TIMRoster"/>
    ///  - <see cref="TOutlookPolicies"/>
    ///  - <see cref="TPropertyNoValue"/>
    ///  - <see cref="TPropertyString"/>
    ///  - <see cref="TPropertyStringList"/>
    ///  - <see cref="TPropertyMember"/>
    ///  - <see cref="TPropertyMembers"/>
    /// </summary>
    public abstract class TPropertyVal : BaseClass
    {
        
    }
}
