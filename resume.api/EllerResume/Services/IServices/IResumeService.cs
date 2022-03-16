using Controllers.Models;
using System.Threading.Tasks;

namespace Controllers.Services
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