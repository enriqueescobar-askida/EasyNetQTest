namespace Messaging.Subscribers.Consumer
{
    using EasyNetQ.AutoSubscribe;
    using MessageTypes.Message;

    /// <summary>
    /// Interface Consumable
    /// </summary>
    /// <seealso cref="EasyNetQ.AutoSubscribe.IConsume{Messaging.MessageTypes.Message.AbstractMessage}" />
    public interface IConsumable : IConsume<AbstractMessage>
    {
        /// <summary>
        /// Consumes the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        new void Consume(AbstractMessage message);
    }
}