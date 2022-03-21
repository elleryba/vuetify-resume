using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Services
{
    /// <summary>
    /// The technical experience service.
    /// </summary>
    public interface ITechnicalExperienceService
    {
        #region Public Methods

        /// <summary>
        /// Gets the technical experience.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<string>> GetTechnicalExperience();

        #endregion Public Methods
    }
}