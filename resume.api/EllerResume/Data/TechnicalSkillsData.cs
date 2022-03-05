namespace Controllers.Data
{
    /// <summary>
    /// The technical skills data.
    /// </summary>
    public class TechnicalSkillsData
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is back end.
        /// </summary>
        /// <value><c>true</c> if this instance is back end; otherwise, <c>false</c>.</value>
        public bool IsBackEnd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is front end.
        /// </summary>
        /// <value><c>true</c> if this instance is front end; otherwise, <c>false</c>.</value>
        public bool IsFrontEnd { get; set; }

        /// <summary>
        /// Gets or sets the skill.
        /// </summary>
        /// <value>The skill.</value>
        public string Skill { get; set; }

        #endregion Public Properties
    }
}