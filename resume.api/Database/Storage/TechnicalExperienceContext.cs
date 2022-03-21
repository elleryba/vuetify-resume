using Common.Services;
using Database.Entities.Types.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Storage.Storage
{
    public partial class TechnicalExperienceContext
        : DbContext
    {
        #region Private Fields

        private readonly IConnectionStringService _connectionStringService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalExperienceContext"/> class.
        /// </summary>
        /// <param name="connectionStringService">The connection string service.</param>
        public TechnicalExperienceContext(IConnectionStringService connectionStringService)
            => _connectionStringService = connectionStringService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalExperienceContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="connectionStringService">The connection string service.</param>
        public TechnicalExperienceContext(DbContextOptions<TechnicalExperienceContext> options,
            IConnectionStringService connectionStringService)
            : base(options) => _connectionStringService = connectionStringService;

        #endregion Public Constructors

        #region Public Properties

        public virtual DbSet<TechnicalExperience> TechnicalExperiences { get; set; }

        #endregion Public Properties

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionStringService.GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TechnicalExperience>(entity =>
            {
                entity.ToTable("TechnicalExperience");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .IsUnicode(false);
            });

            base.OnModelCreating(modelBuilder);
        }

        #endregion Protected Methods
    }
}