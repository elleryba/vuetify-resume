using Controllers.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The job history service.
    /// </summary>
    public interface IJobHistoryService
    {
        #region Public Methods

        /// <summary>
        /// Gets all job history data.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<JobHistoryData>> GetAllJobHistoryData();

        #endregion Public Methods
    }
}