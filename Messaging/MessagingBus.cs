namespace Messaging
{
    using EasyNetQ;

    public class MessagingBus
    {
        // todo move these in to configs
        public static IBus CreateMessagingBus() => RabbitHutch.CreateBus("host=localhost;virtualHost=/;username=guest;password=guest");
    }
}
