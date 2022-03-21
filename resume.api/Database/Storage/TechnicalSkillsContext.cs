using Common.Services;
using Database.Entities.Types.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Storage
{
    public partial class TechnicalSkillsContext
        : DbContext
    {
        #region Private Fields

        private readonly IConnectionStringService _connectionStringService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalSkillsContext"/> class.
        /// </summary>
        /// <param name="connectionStringService">The connection string service.</param>
        public TechnicalSkillsContext(IConnectionStringService connectionStringService)
            => _connectionStringService = connectionStringService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalSkillsContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="connectionStringService">The connection string service.</param>
        public TechnicalSkillsContext(DbContextOptions<TechnicalSkillsContext> options,
            IConnectionStringService connectionStringService)
            : base(options) => _connectionStringService = connectionStringService;

        #endregion Public Constructors

        #region Public Properties

        public virtual DbSet<TechnicalSkill> TechnicalSkills { get; set; }

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

            modelBuilder.Entity<TechnicalSkill>(entity =>
            {
                entity.Property(e => e.Skill)
                    .IsRequired()
                    .IsUnicode(false);
                entity.Property(e => e.BackEnd)
                    .IsRequired()
                    .IsUnicode(false);
                entity.Property(e => e.FrontEnd)
                    .IsRequired()
                    .IsUnicode(false);
                entity.Property(e => e.Id)
                    .IsRequired()
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        #endregion Protected Methods

        #region Private Methods

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        #endregion Private Methods
    }
}