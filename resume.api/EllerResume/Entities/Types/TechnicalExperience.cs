using System.ComponentModel.DataAnnotations;

namespace Controllers.Entities.Types.Entities
{
    /// <summary>
    /// The TechnicalExperience table entity.
    /// </summary>
    public partial class TechnicalExperience
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Key]
        public int Id { get; set; }

        #endregion Public Properties
    }
}