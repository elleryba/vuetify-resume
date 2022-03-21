using Common.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Services
{
    /// <summary>
    /// The job duty service.
    /// </summary>
    public interface IJobDutyService
    {
        #region Public Methods

        /// <summary>
        /// Gets all job duty data.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<JobDutyData>> GetAllJobDutyData();

        #endregion Public Methods
    }
}