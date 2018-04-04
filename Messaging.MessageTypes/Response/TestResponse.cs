namespace Messaging.MessageTypes.Response
{
    using System;

    public class TestResponse : AbstractResponse
    {
        public TestResponse(string response)
        {
            this.Response = (String.IsNullOrWhiteSpace(response)) ? String.Empty : response;
        }
    }
}