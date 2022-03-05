using Controllers.Entities.Types.Entities;
using Microsoft.EntityFrameworkCore;

namespace Controllers.Storage.Storage
{
    public partial class TechnicalExperienceContext : DbContext
    {
        #region Public Constructors

        public TechnicalExperienceContext()
        {
        }

        public TechnicalExperienceContext(DbContextOptions<TechnicalExperienceContext> options)
            : base(options)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public virtual DbSet<TechnicalExperience> TechnicalExperiences { get; set; }

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

        #region Private Methods

        private static string GetConnectionString()
            => "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EllerResume;Integrated Security=True";

        #endregion Private Methods
    }
}