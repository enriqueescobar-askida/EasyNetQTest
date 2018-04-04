namespace Publisher
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
                string input = "";
                Console.WriteLine("Enter a message. 'q' to quit.");
                while ((input = Console.ReadLine()) != "q")
                {
                    bus.Publish(new TextMessage
                        {
                            Text = input
                        });
                }
            }
        }
    }
}