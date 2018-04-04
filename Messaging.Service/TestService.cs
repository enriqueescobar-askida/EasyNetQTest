namespace Messaging.Service
{
    public class TestService : IService
    {
        #region Implementation of IService

        /// <inheritdoc />
        public bool Start()
        {
            return false;
        }

        /// <inheritdoc />
        public bool Stop()
        {
            return false;
        }
        #endregion
    }
}
