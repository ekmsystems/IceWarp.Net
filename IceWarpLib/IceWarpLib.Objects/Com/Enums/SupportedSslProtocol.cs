namespace IceWarpLib.Objects.Com.Enums
{
    public enum SupportedSslProtocol
    {
        /// <summary>
        /// Currently matches TLS1AndNewer, but will be increased in future according to the actual security trends
        /// </summary>
        Default = 0,
        /// <summary>
        /// Supports SSL3 and newer (SSL3,TLS1,TLS1.1.TLS1.2)
        /// (Client will send out TLSv1 client hello messages including extensions and will indicate that it also understands TLSv1.1, TLSv1.2 and permits a fallback to SSLv3)
        /// </summary>
        SSL3AndNewer = 3,
        /// <summary>
        /// Supports TLS1 and newer (TLS1,TLS1.1.TLS1.2)
        /// (Client will send out TLSv1 client hello messages including extensions and will indicate that it also understands TLSv1.1, TLSv1.2)
        /// </summary>
        TLS1AndNewer = 4,
        /// <summary>
        /// Supports TLS1.1 and newer (TLS1.1.TLS1.2)
        /// (Client will send out TLSv1.1 client hello messages including extensions and will indicate that it also understands TLSv1.2)
        /// </summary>
        TLS1_1AndNewer = 5,
        /// <summary>
        /// Supports TLS1.2 and newer (TLS1.2)
        /// (Client will send out TLSv1.2 client hello messages)
        /// </summary>
        TLS1_2AndNewer = 6
    }
}
