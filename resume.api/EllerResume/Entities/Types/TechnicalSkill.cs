using System.ComponentModel.DataAnnotations;

namespace Controllers.Entities.Types.Entities
{
    /// <summary>
    /// The TechnicalSkill table entity.
    /// </summary>
    public partial class TechnicalSkill
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the back end.
        /// </summary>
        /// <value>The back end.</value>
        public bool BackEnd { get; set; }

        /// <summary>
        /// Gets or sets the front end.
        /// </summary>
        /// <value>The front end.</value>
        public bool FrontEnd { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the skill.
        /// </summary>
        /// <value>The skill.</value>
        [Required]
        [StringLength(255)]
        public string Skill { get; set; }

        #endregion Public Properties
    }
}