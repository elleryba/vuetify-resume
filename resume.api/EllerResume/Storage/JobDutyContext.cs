using Controllers.Entities.Types;
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
        #region Public Constructors

        public JobDutyContext()
        {
        }

        public JobDutyContext(DbContextOptions<JobDutyContext> options)
            : base(options)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public virtual DbSet<JobDuty> JobDuties { get; set; }

        #endregion Public Properties

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=EllerResume;Integrated Security=True");
            }
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
    }
}