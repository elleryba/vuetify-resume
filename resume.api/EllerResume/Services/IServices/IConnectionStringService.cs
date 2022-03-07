namespace Controllers.Services
{
    /// <summary>
    /// The connection string service.
    /// </summary>
    public interface IConnectionStringService
    {
        #region Public Methods

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <returns></returns>
        public string GetConnectionString();

        #endregion Public Methods
    }
}