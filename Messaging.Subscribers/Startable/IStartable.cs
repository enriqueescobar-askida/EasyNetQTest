namespace Messaging.Subscribers.Startable
{
    /// <summary>
    /// Interface Startable
    /// </summary>
    public interface IStartable
    {
        /// <summary>
        /// Starts this instance.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops this instance.
        /// </summary>
        void Stop();
    }
}