using Common.Services;
using Database.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Database
{
    public static class DatabaseServiceExtensions
    {
        #region Public Methods

        // This method gets called by the runtime. Use this method to add services to the container.
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IConnectionStringService, ConnectionStringService>();
            services.AddScoped<IJobDutyService, JobDutyService>();
            services.AddScoped<IJobHistoryService, JobHistoryService>();
            services.AddScoped<IResumeService, ResumeService>();
            services.AddScoped<ITechnicalExperienceService, TechnicalExperienceService>();
            services.AddScoped<ITechnicalSkillsService, TechnicalSkillsService>();

            return services;
        }

        #endregion Public Methods
    }
}