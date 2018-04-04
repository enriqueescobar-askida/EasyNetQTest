namespace Messaging.MessageTypes.Response
{
    /// <summary>
    /// Abstract Response
    /// </summary>
    public abstract class AbstractResponse
    {
        /// <summary>
        /// Gets the response.
        /// </summary>
        /// <value>
        /// The response.
        /// </value>
        public string Response { get; internal set; }
    }
}