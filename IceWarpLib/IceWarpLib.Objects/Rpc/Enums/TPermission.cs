namespace IceWarpLib.Objects.Rpc.Enums
{
    /// <summary>
    /// Used for defining permissions on certain item
    /// <para><see href="https://www.icewarp.co.uk/api/#TPermission">https://www.icewarp.co.uk/api/#TPermission</see></para>
    /// </summary>
    public enum TPermission
    {
        None = 0,
        Read = 1,
        ReadWrite = 2,
        ForcedNone =3,
        ForcedRead = 4,
        ForcedReadWrite = 5
    }
}
