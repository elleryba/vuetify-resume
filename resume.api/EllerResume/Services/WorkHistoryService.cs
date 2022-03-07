using Controllers.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The work history service.
    /// </summary>
    /// <seealso cref="IWorkHistoryService"/>
    public class WorkHistoryService
        : IWorkHistoryService
    {
        #region Private Fields

        private readonly IJobDutyService _jobDutyService;
        private readonly IJobHistoryService _jobHistoryService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkHistoryService"/> class.
        /// </summary>
        /// <param name="jobDutyService">The job duty service.</param>
        /// <param name="jobHistoryService">The job history service.</param>
        public WorkHistoryService(IJobDutyService jobDutyService,
            IJobHistoryService jobHistoryService)
        {
            _jobDutyService = jobDutyService;
            _jobHistoryService = jobHistoryService;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <inheritdoc/>
        public async Task<IEnumerable<WorkHistoryView>> GetWorkHistory()
        {
            List<WorkHistoryView> workHistories = new();

            var histories = await _jobHistoryService.GetAllJobHistoryData();
            var duties = await _jobDutyService.GetAllJobDutyData();

            // TODO - better than it was but... idk i feel like there is a better solution
            foreach (var h in histories)
            {
                var matchingDuties = duties.Where(x => x.JobId == h.Id);

                var newHistory = new WorkHistoryView()
                {
                    Duties = matchingDuties.Select(x => x.Duty).ToList(),
                    JobId = h.Id,
                    CompanyName = h.CompanyName,
                    Title = h.Title,
                    StartDate = h.StartDate,
                    EndDate = h.EndDate,
                    WorkedRemote = h.WorkedRemote
                };

                workHistories.Add(newHistory);
            }

            // TODO - this is a lil hacky but... thats showbiz baby!
            return workHistories.OrderBy(workHistory => workHistory.EndDate ?? DateTime.Now).Reverse();
        }

        #endregion Public Methods
    }
}