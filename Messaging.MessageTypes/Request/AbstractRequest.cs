namespace Messaging.MessageTypes.Request
{
    /// <summary>
    /// Abstract Request
    /// </summary>
    public abstract class AbstractRequest
    {
        /// <summary>
        /// Gets the request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        public string Request { get; internal set; }
    }
}