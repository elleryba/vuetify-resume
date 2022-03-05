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
        private readonly IJobDutiesService _jobDutiesService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="cardService">The card service.</param>
        /// <param name="jobDutiesService">The job duties service.</param>
        public HomeController(ICardService cardService,
            IJobDutiesService jobDutiesService)
        {
            _cardService = cardService;
            _jobDutiesService = jobDutiesService;
        }

        #endregion Public Constructors

        #region Public Methods

        [Route("job_duties")]
        [HttpGet]
        public async Task<ActionResult<JobDutyData>> GetJobDutyData()
        {
            var result = await _jobDutiesService.GetAllJobDuties();

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