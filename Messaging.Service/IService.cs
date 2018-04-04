namespace Messaging.Service
{
    /// <summary>
    /// Interface Service
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Starts this instance.
        /// </summary>
        /// <returns></returns>
        bool Start();

        /// <summary>
        /// Stops this instance.
        /// </summary>
        /// <returns></returns>
        bool Stop();
    }
}