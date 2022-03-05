namespace Common.Models
{
    /// <summary>
    /// Model of a card.
    /// </summary>
    public interface ICard
    {
        /// <summary>
        /// Gets or sets the image source.
        /// </summary>
        /// <value>The image source.</value>
        public string ImageSource { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public string Text { get; set; }
    }
}