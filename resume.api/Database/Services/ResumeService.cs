using Common.Models;
using Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Services
{
    /// <summary>
    /// The resume service.
    /// </summary>
    /// <seealso cref="IResumeService"/>
    public class ResumeService
        : IResumeService
    {
        #region Private Fields

        private readonly IJobDutyService _jobDutyService;
        private readonly IJobHistoryService _jobHistoryService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeService"/> class.
        /// </summary>
        /// <param name="jobDutyService">The job duty service.</param>
        /// <param name="jobHistoryService">The job history service.</param>
        public ResumeService(IJobDutyService jobDutyService,
            IJobHistoryService jobHistoryService)
        {
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
                var duties = jobDuties.Where(x => x.JobId == jh.Id);

                jobs.Add(new()
                {
                    CompanyName = jh.CompanyName,
                    EndDate = jh.EndDate,
                    Id = jh.Id,
                    JobDuties = duties.Select(x => x.Duty).ToList(),
                    StartDate = jh.StartDate,
                    Title = jh.Title,
                    WasRemotePosition = jh.WorkedRemote
                });
            }

            return new ResumeModel() { Resume = jobs.OrderBy(x => x.EndDate ?? DateTime.Now).Reverse() };
        }

        #endregion Public Methods
    }
}