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
    /// The job duties service.
    /// </summary>
    /// <seealso cref="IJobDutiesService"/>
    public class JobDutiesService
        : IJobDutiesService
    {
        #region Public Methods

        /// <inheritdoc/>
        public Task<IEnumerable<JobDutyData>> GetAllJobDuties()
        {
            List<JobDutyData> data = new();

            using (JobDutyContext dbContext = new())
            {
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
            }

            return Task.FromResult(data.AsEnumerable());
        }

        #endregion Public Methods
    }
}