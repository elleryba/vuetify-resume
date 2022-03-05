using Controllers.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The job duties service.
    /// </summary>
    public interface IJobDutiesService
    {
        #region Public Methods

        public Task<IEnumerable<JobDutyData>> GetAllJobDuties();

        #endregion Public Methods
    }
}