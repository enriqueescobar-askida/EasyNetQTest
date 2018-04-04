namespace Messaging.Subscribers.Responder
{
    using MessageTypes.Response;
    using MessageTypes.Request;

    /// <summary>
    /// Interface Respondable
    /// </summary>
    public interface IRespondable
    {
        /// <summary>
        /// Subscribes this instance.
        /// </summary>
        void Subscribe();

        /// <summary>
        /// The response.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>The <see cref="AbstractResponse"/>.</returns>
        AbstractResponse Response(AbstractRequest request);
    }
}