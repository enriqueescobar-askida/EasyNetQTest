namespace Messaging.Subscribers.Dispatcher
{
    using EasyNetQ.AutoSubscribe;

    /// <inheritdoc />
    /// <summary>
    /// Interface Dispatchable
    /// </summary>
    /// <seealso cref="EasyNetQ.AutoSubscribe.IAutoSubscriberMessageDispatcher" />
    internal interface IDispatchable : IAutoSubscriberMessageDispatcher
    {

    }
}