using Controllers.Entities.Types.Entities;
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
        #region Public Constructors

        public JobHistoryContext()
        {
        }

        public JobHistoryContext(DbContextOptions<JobHistoryContext> options)
            : base(options)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public virtual DbSet<JobHistory> JobHistories { get; set; }

        #endregion Public Properties

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());
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

        #region Private Methods

        private static string GetConnectionString()
            => "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EllerResume;Integrated Security=True";

        #endregion Private Methods
    }
}