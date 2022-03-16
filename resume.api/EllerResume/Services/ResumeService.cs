using Controllers.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The resume service.
    /// </summary>
    /// <seealso cref="IResumeService"/>
    public class ResumeService
        : IResumeService
    {
        #region Private Fields

        private readonly IConnectionStringService _conntectionStringService;
        private readonly IJobDutyService _jobDutyService;
        private readonly IJobHistoryService _jobHistoryService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeService"/> class.
        /// </summary>
        /// <param name="connectionStringService">The connection string service.</param>
        /// <param name="jobDutyService">The job duty service.</param>
        /// <param name="jobHistoryService">The job history service.</param>
        public ResumeService(IConnectionStringService connectionStringService,
            IJobDutyService jobDutyService,
            IJobHistoryService jobHistoryService)
        {
            _conntectionStringService = connectionStringService;
            _jobDutyService = jobDutyService;
            _jobHistoryService = jobHistoryService;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <inheritdoc/>
        public async Task<ResumeModel> BuildResume()
        {
            var jobHistories = await _jobHistoryService.GetAllJobHistoryData();
            var jobDuties = await _jobDutyService.GetAllJobDutyData();

            List<JobModel> jobs = new();

            foreach (var jh in jobHistories)
            {
                List<string> duties = new();

                foreach (var jd in jobDuties.Where(x => x.JobId == jh.Id))
                    duties.Add(jd.Duty);

                jobs.Add(new()
                {
                    CompanyName = jh.CompanyName,
                    Title = jh.Title,
                    StartDate = jh.StartDate,
                    EndDate = jh.EndDate,
                    WasRemotePosition = jh.WorkedRemote,
                    JobDuties = duties
                });
            }

            return new ResumeModel() { Resume = jobs };
        }

        #endregion Public Methods
    }
}