﻿namespace Messaging.Publishers
{
    using System;

    /// <summary>
    /// Interface Publishable
    /// </summary>
    public interface IPublishable
    {
        /// <summary>
        /// Publishes the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Publish(dynamic message);

        /// <summary>
        /// Requests the specified request.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="onResponse">The on response.</param>
        void Request<TRequest, TResponse>(TRequest request, Action<TResponse> onResponse)
            where TRequest : class
            where TResponse : class;

        /// <summary>
        /// Responses the specified on response.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="onResponse">The on response.</param>
        void Response<TRequest, TResponse>(Func<TRequest, TResponse> onResponse)
            where TRequest : class
            where TResponse : class;
    }
}
