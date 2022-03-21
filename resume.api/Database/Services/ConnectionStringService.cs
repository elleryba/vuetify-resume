using Common.Services;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Database.Services
{
    /// <summary>
    /// The connection string service.
    /// </summary>
    /// <seealso cref="IConnectionStringService"/>
    public class ConnectionStringService
        : IConnectionStringService
    {
        #region Public Methods

        /// <inheritdoc/>
        public string GetConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile("appsettings.json")
                .Build();
            return configuration.GetConnectionString("DefaultConnection");
        }

        #endregion Public Methods
    }
}