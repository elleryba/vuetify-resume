using System;
using System.Collections.Generic;

namespace Controllers.Models
{
    /// <summary>
    /// The work history model.
    /// </summary>
    public class WorkHistoryModel
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the duties.
        /// </summary>
        /// <value>The duties.</value>
        public ICollection<string> Duties { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>The end date.</value>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the job identifier.
        /// </summary>
        /// <value>The job identifier.</value>
        public int JobId { get; set; }

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
        /// Gets or sets a value indicating whether [worked remote].
        /// </summary>
        /// <value><c>true</c> if [worked remote]; otherwise, <c>false</c>.</value>
        public bool WorkedRemote { get; set; }

        #endregion Public Properties
    }
}