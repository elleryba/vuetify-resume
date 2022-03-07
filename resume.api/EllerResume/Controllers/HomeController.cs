using Controllers.Data;
using Controllers.Services;
using Controllers.Views;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EllerResume.Controllers
{
    /// <summary>
    /// The main controller used to retrieve info for the cards on the UI.
    /// </summary>
    /// <seealso cref="Controller"/>
    [ApiController]
    [Route("api")]
    public class HomeController
        : Controller
    {
        #region Private Fields

        private readonly IJobDutyService _jobDutyService;
        private readonly IJobHistoryService _jobHistoryService;
        private readonly IWorkHistoryService _workHistoryService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="jobDutyService">The job duty service.</param>
        /// <param name="jobHistoryService">The job history service.</param>
        /// <param name="workHistoryService">The work history service.</param>
        public HomeController(IJobDutyService jobDutyService,
            IJobHistoryService jobHistoryService,
            IWorkHistoryService workHistoryService)
        {
            _jobDutyService = jobDutyService;
            _jobHistoryService = jobHistoryService;
            _workHistoryService = workHistoryService;
        }

        #endregion Public Constructors

        #region Public Methods

        // TODO - remove - for testing only
        [Route("job_duties")]
        [HttpGet]
        public async Task<ActionResult<JobDutyData>> GetJobDutyData()
        {
            var result = await _jobDutyService.GetAllJobDutyData();

            return Ok(result);
        }

        // TODO - remove - for testing only
        [Route("job_histories")]
        [HttpGet]
        public async Task<ActionResult<JobDutyData>> GetJobHistoryData()
        {
            var result = await _jobHistoryService.GetAllJobHistoryData();

            return Ok(result);
        }

        [Route("work_history")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkHistoryView>>> GetWorkHistory()
        {
            var result = await _workHistoryService.GetWorkHistory();

            return Ok(result);
        }

        #endregion Public Methods
    }
}