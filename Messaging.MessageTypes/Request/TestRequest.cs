namespace Messaging.MessageTypes.Request
{
    using System;

    public class TestRequest : AbstractRequest
    {
        public TestRequest(string request)
        {
            this.Request = (String.IsNullOrWhiteSpace(request)) ? String.Empty : request;
        }
    }
}