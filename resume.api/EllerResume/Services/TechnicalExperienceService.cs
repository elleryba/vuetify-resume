using Controllers.Data;
using Controllers.Entities.Types.Entities;
using Controllers.Storage.Storage;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The technical experience service.
    /// </summary>
    /// <seealso cref="ITechnicalExperienceService"/>
    public class TechnicalExperienceService
        : ITechnicalExperienceService
    {
        #region Private Fields

        private readonly IConnectionStringService _connectionStringService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalExperienceService"/> class.
        /// </summary>
        /// <param name="connectionStringService">The connection string service.</param>
        public TechnicalExperienceService(IConnectionStringService connectionStringService)
            => _connectionStringService = connectionStringService;

        #endregion Public Constructors

        #region Public Methods

        /// <inheritdoc/>
        public Task<IEnumerable<string>> GetTechnicalExperience()
        {
            List<TechnicalExperienceData> data = new();

            using TechnicalExperienceContext dbContext = new(_connectionStringService);
            DbSet<TechnicalExperience> technicalExperience = dbContext.TechnicalExperiences;

            foreach (var item in technicalExperience)
                data.Add(new()
                {
                    Description = item.Description,
                    Id = item.Id
                });

            IEnumerable<string> experienceItems = data.Select(x => x.Description);

            return Task.FromResult(experienceItems);
        }

        #endregion Public Methods
    }
}