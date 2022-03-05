using Controllers.Entities.Types.Entities;
using Controllers.Services;
using Microsoft.EntityFrameworkCore;

namespace Controllers.Storage.Storage
{
    /// <summary>
    /// The job history context.
    /// </summary>
    /// <seealso cref="DbContext"/>
    public partial class JobHistoryContext
        : DbContext
    {
        #region Private Fields

        #region Private Fields

        private readonly IConnectionStringService _connectionStringService;

        #endregion Private Fields

        #endregion Private Fields

        #region Public Constructors

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JobHistoryContext"/> class.
        /// </summary>
        /// <param name="connectionStringService">The connection string service.</param>
        public JobHistoryContext(IConnectionStringService connectionStringService)
            => _connectionStringService = connectionStringService;

        /// <summary>
        /// Initializes a new instance of the <see cref="JobHistoryContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="connectionStringService">The connection string service.</param>
        public JobHistoryContext(DbContextOptions<JobHistoryContext> options,
            IConnectionStringService connectionStringService)
            : base(options) => _connectionStringService = connectionStringService;

        #endregion Public Constructors

        #endregion Public Constructors

        #region Public Properties

        #region Public Properties

        public virtual DbSet<JobHistory> JobHistories { get; set; }

        #endregion Public Properties

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

            modelBuilder.Entity<JobHistory>(entity =>
            {
                entity.ToTable("JobHistory");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.WorkedRemote)
                    .IsRequired()
                    .IsUnicode(false);
            });

            base.OnModelCreating(modelBuilder);
        }

        #endregion Protected Methods
    }
}