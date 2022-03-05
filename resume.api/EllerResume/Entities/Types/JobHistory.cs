using System;
using System.ComponentModel.DataAnnotations;

namespace Controllers.Entities.Types.Entities
{
    /// <summary>
    /// The JobHistory table entity.
    /// </summary>
    public partial class JobHistory
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        [Required]
        [StringLength(255)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>The end date.</value>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>The start date.</value>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the worked remote.
        /// </summary>
        /// <value>The worked remote.</value>
        [Required]
        public bool WorkedRemote { get; set; }

        #endregion Public Properties
    }
}