using Controllers.Data;
using Controllers.Entities.Types.Entities;
using Controllers.Storage.Storage;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The job history service.
    /// </summary>
    /// <seealso cref="IJobHistoryService"/>
    public class JobHistoryService
        : IJobHistoryService
    {
        #region Private Fields

        private readonly IConnectionStringService _connectionStringService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JobHistoryService"/> class.
        /// </summary>
        /// <param name="connectionStringService">The connection string service.</param>
        public JobHistoryService(IConnectionStringService connectionStringService)
            => _connectionStringService = connectionStringService;

        #endregion Public Constructors

        #region Public Methods

        /// <inheritdoc/>
        public Task<IEnumerable<JobHistoryData>> GetAllJobHistoryData()
        {
            List<JobHistoryData> data = new();

            using (JobHistoryContext dbContext = new(_connectionStringService))
            {
                DbSet<JobHistory> jobHistories = dbContext.JobHistories;

                foreach (JobHistory history in jobHistories)
                {
                    data.Add(new()
                    {
                        CompanyName = history.CompanyName,
                        EndDate = history.EndDate,
                        Id = history.Id,
                        StartDate = history.StartDate,
                        Title = history.Title,
                        WorkedRemote = history.WorkedRemote
                    });
                }
            }

            return Task.FromResult(data.AsEnumerable());
        }

        #endregion Public Methods
    }
}