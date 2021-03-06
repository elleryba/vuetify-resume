using Common.Models;
using System.Threading.Tasks;

namespace Common.Services
{
    /// <summary>
    /// The resume service.
    /// </summary>
    public interface IResumeService
    {
        #region Public Methods

        /// <summary>
        /// Builds the resume.
        /// </summary>
        /// <returns></returns>
        public Task<ResumeModel> BuildResume();

        #endregion Public Methods
    }
}