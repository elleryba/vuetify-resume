using System.ComponentModel.DataAnnotations;

namespace Controllers.Entities.Types
{
    /// <summary>
    /// The JobDuty entity.
    /// </summary>
    public partial class JobDuty
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the duty.
        /// </summary>
        /// <value>The duty.</value>
        [Required]
        [StringLength(1000)]
        public string Duty { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        /// <value>The job identifier.</value>
        [Required]
        public int JobId { get; set; }

        #endregion Public Properties
    }
}