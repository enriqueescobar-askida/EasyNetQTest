namespace Messaging.MessageTypes.Message
{
    /// <summary>
    /// Abstract Message
    /// </summary>
    public abstract class AbstractMessage
    {
        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; internal set; }
    }
}