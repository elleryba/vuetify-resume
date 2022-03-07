using Controllers.Data;
using Controllers.Entities.Types.Entities;
using Controllers.Storage;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The technical skills service.
    /// </summary>
    /// <seealso cref="ITechnicalSkillsService"/>
    public class TechnicalSkillsService
        : ITechnicalSkillsService
    {
        #region Private Fields

        private readonly IConnectionStringService _connectionStringService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalSkillsService"/> class.
        /// </summary>
        /// <param name="connectionStringService">The connection string service.</param>
        public TechnicalSkillsService(IConnectionStringService connectionStringService)
            => _connectionStringService = connectionStringService;

        #endregion Public Constructors

        #region Public Methods

        /// <inheritdoc/>
        public Task<IEnumerable<TechnicalSkillsData>> GetAllSkills()
        {
            List<TechnicalSkillsData> data = new();

            using TechnicalSkillsContext dbContext = new(_connectionStringService);
            DbSet<TechnicalSkill> technicalSkills = dbContext.TechnicalSkills;

            foreach (var skill in technicalSkills)
                data.Add(new()
                {
                    Id = skill.Id,
                    IsFrontEnd = skill.FrontEnd,
                    IsBackEnd = skill.BackEnd,
                    Skill = skill.Skill
                });

            return Task.FromResult(data.AsEnumerable());
        }

        /// <inheritdoc/>
        public Task<IEnumerable<TechnicalSkillsData>> GetBackEndSkills()
        {
            List<TechnicalSkillsData> data = new();

            using TechnicalSkillsContext dbContext = new(_connectionStringService);
            DbSet<TechnicalSkill> technicalSkills = dbContext.TechnicalSkills;

            foreach (var skill in technicalSkills.Where(x => x.BackEnd))
                data.Add(new()
                {
                    Id = skill.Id,
                    IsFrontEnd = skill.FrontEnd,
                    IsBackEnd = skill.BackEnd,
                    Skill = skill.Skill
                });

            return Task.FromResult(data.AsEnumerable());
        }

        /// <inheritdoc/>
        public Task<IEnumerable<TechnicalSkillsData>> GetFrontEndSkills()
        {
            List<TechnicalSkillsData> data = new();

            using TechnicalSkillsContext dbContext = new(_connectionStringService);
            DbSet<TechnicalSkill> technicalSkills = dbContext.TechnicalSkills;

            foreach (var skill in technicalSkills.Where(x => x.FrontEnd))
                data.Add(new()
                {
                    Id = skill.Id,
                    IsFrontEnd = skill.FrontEnd,
                    IsBackEnd = skill.BackEnd,
                    Skill = skill.Skill
                });

            return Task.FromResult(data.AsEnumerable());
        }

        #endregion Public Methods
    }
}