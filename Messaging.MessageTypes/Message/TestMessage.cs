namespace Messaging.MessageTypes.Message
{
    using System;

    public class TestMessage : AbstractMessage
    {
        public TestMessage(string message)
        {
            this.Message = (String.IsNullOrWhiteSpace(message)) ? String.Empty : message;
        }
    }
}