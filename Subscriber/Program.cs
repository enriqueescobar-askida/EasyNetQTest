namespace Subscriber
{
    using System;
    using EasyNetQ;
    using Messages;

    class Program
    {
        static void Main(string[] args)
        {
            using (IBus bus = RabbitHutch.CreateBus("host=localhost"))
            {
                bus.Subscribe<TextMessage>("test", HandleTextMessage);

                Console.WriteLine("Listening for messages. Hit <return> to quit.");
                Console.ReadLine();
            }
        }

        static void HandleTextMessage(TextMessage textMessage)
        {
            Console.WriteLine("Got message: {0}", textMessage.Text);
        }
    }
}