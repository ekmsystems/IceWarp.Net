namespace IceWarpLib.Objects.Rpc.Enums
{
    /// <summary>
    /// Used for defining permissions on certain item
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
