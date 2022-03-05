using Common.Models;

namespace Controllers.Models
{
    /// <summary>
    /// The card model.
    /// </summary>
    /// <seealso cref="ICard"/>
    public class Card
        : ICard
    {
        /// <inheritdoc/>
        public string ImageSource { get; set; }

        /// <inheritdoc/>
        public string Title { get; set; }

        /// <inheritdoc/>
        public string Text { get; set; }
    }
}