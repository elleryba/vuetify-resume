using Controllers.Views;
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

            // TODO - i absolutely hate this
            foreach (var h in histories.Reverse())
            {
                var newHistory = new WorkHistoryView()
                {
                    JobId = h.Id,
                    CompanyName = h.CompanyName,
                    Title = h.Title,
                    StartDate = h.StartDate,
                    EndDate = h.EndDate,
                    WorkedRemote = h.WorkedRemote
                };

                foreach (var d in duties.Reverse())
                    if (d.JobId == newHistory.JobId)
                        newHistory.Duties.Add(d.Duty);

                workHistories.Add(newHistory);
            }

            // TODO - need to figure out how to get null DateTime to the top of the list
            return workHistories.OrderBy(workHistory => workHistory.EndDate).Reverse();
        }

        #endregion Public Methods
    }
}