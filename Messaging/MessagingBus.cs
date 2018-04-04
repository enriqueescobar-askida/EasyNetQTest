namespace Messaging
{
    using EasyNetQ;

    public class MessagingBus
    {
        public static IBus CreateMessagingBus() => RabbitHutch.CreateBus("host=localhost;virtualHost=/;username=guest;password=guest");
    }
}
