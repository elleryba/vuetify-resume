using Controllers.Models;
using Controllers.Services;
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

        private readonly ITechnicalSkillsService _technicalSkillsService;
        private readonly IWorkHistoryService _workHistoryService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="workHistoryService">The work history service.</param>
        /// <param name="technicalSkillsService">The technical skills service.</param>
        public HomeController(IWorkHistoryService workHistoryService,
            ITechnicalSkillsService technicalSkillsService)
        {
            _technicalSkillsService = technicalSkillsService;
            _workHistoryService = workHistoryService;
        }

        #endregion Public Constructors

        #region Public Methods

        [Route("technical_skills")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAllTechnicalSkills()
        {
            var result = await _technicalSkillsService.GetAllSkills();

            return Ok(result);
        }

        [Route("technical_skills/back_end")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechnicalSkillsModel>>> GetBackEndSkills()
        {
            var result = await _technicalSkillsService.GetBackEndSkills();

            return Ok(result);
        }

        [Route("technical_skills/front_end")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechnicalSkillsModel>>> GetFrontEndSkills()
        {
            var result = await _technicalSkillsService.GetFrontEndSkills();

            return Ok(result);
        }

        [Route("work_history")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkHistoryModel>>> GetWorkHistory()
        {
            var result = await _workHistoryService.GetWorkHistory();

            return Ok(result);
        }

        #endregion Public Methods
    }
}