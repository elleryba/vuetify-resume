using System;
using System.Collections.Generic;

namespace Controllers.Models
{
    /// <summary>
    /// The job model.
    /// </summary>
    public class JobModel
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
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
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the job duties.
        /// </summary>
        /// <value>The job duties.</value>
        public IEnumerable<string> JobDuties { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [was remote position].
        /// </summary>
        /// <value><c>true</c> if [was remote position]; otherwise, <c>false</c>.</value>
        public bool WasRemotePosition { get; set; }

        #endregion Public Properties
    }
}