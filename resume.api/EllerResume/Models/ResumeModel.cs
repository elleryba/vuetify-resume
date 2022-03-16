using System.Collections.Generic;

namespace Controllers.Models
{
    /// <summary>
    /// The resume model.
    /// </summary>
    public class ResumeModel
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the resume.
        /// </summary>
        /// <value>The resume.</value>
        public IEnumerable<JobModel> Resume { get; set; }

        #endregion Public Properties
    }
}