namespace Messaging.Subscribers.Dispatcher
{
    using System.Threading.Tasks;
    using EasyNetQ.AutoSubscribe;

    public class TestMessageDispatcher : IDispatchable
    {
        #region Implementation of IAutoSubscriberMessageDispatcher

        public void Dispatch<TMessage, TConsumer>(TMessage message) where TMessage : class where TConsumer : IConsume<TMessage>
        {
        }

        public Task DispatchAsync<TMessage, TConsumer>(TMessage message) where TMessage : class where TConsumer : IConsumeAsync<TMessage>
        {
            return null;
        }

        #endregion
    }
}