using Controllers.Entities.Types;
using Controllers.Services;
using Microsoft.EntityFrameworkCore;

namespace Controllers.Storage
{
    /// <summary>
    /// The job duty context.
    /// </summary>
    /// <seealso cref="DbContext"/>
    public partial class JobDutyContext
        : DbContext
    {
        #region Private Fields

        private readonly IConnectionStringService _service;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDutyContext"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public JobDutyContext(IConnectionStringService service) => _service = service;

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDutyContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="service">The service.</param>
        public JobDutyContext(DbContextOptions<JobDutyContext> options,
            IConnectionStringService service)
            : base(options) => _service = service;

        #endregion Public Constructors

        #region Public Properties

        public virtual DbSet<JobDuty> JobDuties { get; set; }

        #endregion Public Properties

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_service.GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<JobDuty>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.Duty).IsUnicode(false);

                entity.Property(e => e.JobId).IsUnicode(false);
            });

            base.OnModelCreating(modelBuilder);
        }

        #endregion Protected Methods

        #region Private Methods

        //private static string GetConnectionString()
        //{
        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //        .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
        //        .AddJsonFile("appsettings.json")
        //        .Build();
        //    return configuration.GetConnectionString("DefaultConnection");
        //}

        #endregion Private Methods
    }
}