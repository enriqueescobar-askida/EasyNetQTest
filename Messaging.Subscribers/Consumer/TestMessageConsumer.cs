namespace Messaging.Subscribers.Consumer
{
    using MessageTypes.Message;

    /// <summary>
    /// TestMessage Consumer
    /// </summary>
    /// <seealso cref="Messaging.Subscribers.Consumer.IConsumable" />
    public class TestMessageConsumer : IConsumable
    {
        #region Implementation of IConsume<in AbstractMessage>
        /// <summary>
        /// Consumes the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Consume(AbstractMessage message)
        {
        }
        #endregion
    }
}