namespace Griffin.Networking.Protocol.Http.Protocol
{
    /// <summary>
    /// A cookie
    /// </summary>
    public interface IHttpCookie
    {
        /// <summary>
        /// Gets the cookie identifier.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets value. 
        /// </summary>
        string Value { get; }
    }
}