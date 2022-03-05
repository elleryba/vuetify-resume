using Controllers.Controllers.Responses;
using Controllers.Data;
using Controllers.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
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

        private readonly ICardService _cardService;
        private readonly IJobDutyService _jobDutyService;
        private readonly IJobHistoryService _jobHistoryService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="cardService">The card service.</param>
        /// <param name="jobDutyService">The job duty service.</param>
        /// <param name="jobHistoryService">The job history service.</param>
        public HomeController(ICardService cardService,
            IJobDutyService jobDutyService,
            IJobHistoryService jobHistoryService)
        {
            _cardService = cardService;
            _jobDutyService = jobDutyService;
            _jobHistoryService = jobHistoryService;
        }

        #endregion Public Constructors

        #region Public Methods

        [Route("job_duties")]
        [HttpGet]
        public async Task<ActionResult<JobDutyData>> GetJobDutyData()
        {
            var result = await _jobDutyService.GetAllJobDutyData();

            return Ok(result);
        }

        [Route("job_histories")]
        [HttpGet]
        public async Task<ActionResult<JobDutyData>> GetJobHistoryData()
        {
            var result = await _jobHistoryService.GetAllJobHistoryData();

            return Ok(result);
        }

        [Route("cards")]
        [HttpGet]
        public async Task<ActionResult<CardsResponse>> GetVehicleInfo(CancellationToken cancellationToken)
        {
            var result = await _cardService.GetCards(cancellationToken);

            return Ok(result);
        }

        #endregion Public Methods
    }
}