using Controllers.Data;
using Controllers.Entities.Types;
using Controllers.Storage;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The job duty service.
    /// </summary>
    /// <seealso cref="IJobDutyService"/>
    public class JobDutyService
        : IJobDutyService
    {
        #region Private Fields

        private readonly IConnectionStringService _connectionStringService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDutyService"/> class.
        /// </summary>
        /// <param name="connectionStringService">The service.</param>
        public JobDutyService(IConnectionStringService connectionStringService)
            => _connectionStringService = connectionStringService;

        #endregion Public Constructors

        #region Public Methods

        /// <inheritdoc/>
        public Task<IEnumerable<JobDutyData>> GetAllJobDutyData()
        {
            List<JobDutyData> data = new();

            using JobDutyContext dbContext = new(_connectionStringService);
            DbSet<JobDuty> jobDuties = dbContext.JobDuties;

            foreach (JobDuty duty in jobDuties)
            {
                data.Add(new()
                {
                    Id = duty.Id,
                    Duty = duty.Duty,
                    JobId = duty.JobId
                });
            }

            return Task.FromResult(data.AsEnumerable());
        }

        #endregion Public Methods
    }
}