namespace Messaging.Subscribers.Responder
{
    using MessageTypes.Request;
    using MessageTypes.Response;

    public class TestRequestResponder : IRespondable
    {
        #region Implementation of IRespondable

        public void Subscribe()
        {
        }

        /// <summary>
        /// The response.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>The <see cref="AbstractResponse"/>.</returns>
        public AbstractResponse Response(AbstractRequest request)
        {
            return null;
        }

        #endregion
    }
}