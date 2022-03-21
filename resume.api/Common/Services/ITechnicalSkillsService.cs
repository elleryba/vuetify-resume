using Common.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Services
{
    /// <summary>
    /// The technical skill service.
    /// </summary>
    public interface ITechnicalSkillsService
    {
        #region Public Methods

        /// <summary>
        /// Gets the all skills.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<string>> GetAllSkills();

        /// <summary>
        /// Gets the back end skills.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<TechnicalSkillsData>> GetBackEndSkills();

        /// <summary>
        /// Gets the front end skills.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<TechnicalSkillsData>> GetFrontEndSkills();

        #endregion Public Methods
    }
}