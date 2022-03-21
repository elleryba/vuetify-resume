namespace Common.Models
{
    /// <summary>
    /// The technical skills model.
    /// </summary>
    public class TechnicalSkillsModel
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether this instance is back end skill.
        /// </summary>
        /// <value><c>true</c> if this instance is back end skill; otherwise, <c>false</c>.</value>
        public bool IsBackEndSkill { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is front end skill.
        /// </summary>
        /// <value><c>true</c> if this instance is front end skill; otherwise, <c>false</c>.</value>
        public bool IsFrontEndSkill { get; set; }

        /// <summary>
        /// Gets or sets the skill.
        /// </summary>
        /// <value>The skill.</value>
        public string Skill { get; set; }

        #endregion Public Properties
    }
}