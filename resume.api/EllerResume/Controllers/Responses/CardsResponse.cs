using Controllers.Models;
using System.Collections.Generic;

namespace Controllers.Controllers.Responses
{
    /// <summary>
    /// The cards response returned to the UI from the HomeController.
    /// </summary>
    public class CardsResponse
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the cards.
        /// </summary>
        /// <value>The cards.</value>
        public IEnumerable<Card> Cards { get; set; }

        #endregion Public Properties
    }
}