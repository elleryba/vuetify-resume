using Controllers.Views;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The work history service.
    /// </summary>
    public interface IWorkHistoryService
    {
        #region Public Methods

        /// <summary>
        /// Gets the work history.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<WorkHistoryView>> GetWorkHistory();

        #endregion Public Methods
    }
}