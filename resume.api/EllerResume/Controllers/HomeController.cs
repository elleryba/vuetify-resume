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

        private readonly IResumeService _resumeService;
        private readonly ITechnicalExperienceService _technicalExperienceService;
        private readonly ITechnicalSkillsService _technicalSkillsService;
        private readonly IWorkHistoryService _workHistoryService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="resumeService">The resume service.</param>
        /// <param name="technicalExperienceService">The technical experience service.</param>
        /// <param name="technicalSkillsService">The technical skills service.</param>
        /// <param name="workHistoryService">The work history service.</param>
        public HomeController(IResumeService resumeService,
            ITechnicalExperienceService technicalExperienceService,
            ITechnicalSkillsService technicalSkillsService,
            IWorkHistoryService workHistoryService)
        {
            _resumeService = resumeService;
            _technicalExperienceService = technicalExperienceService;
            _technicalSkillsService = technicalSkillsService;
            _workHistoryService = workHistoryService;
        }

        #endregion Public Constructors

        #region Public Methods

        [Route("resume")]
        [HttpGet]
        public async Task<ActionResult<ResumeModel>> GetResume()
        {
            var result = await _resumeService.BuildResume();

            return Ok(result);
        }

        [Route("technical_experience")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetTechnicalExperience()
        {
            var result = await _technicalExperienceService.GetTechnicalExperience();

            return Ok(result);
        }

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