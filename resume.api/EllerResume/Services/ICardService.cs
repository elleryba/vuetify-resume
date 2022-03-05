using Controllers.Controllers.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The card service.
    /// </summary>
    public interface ICardService
    {
        #region Public Methods

        /// <summary>
        /// Gets the cards.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public Task<CardsResponse> GetCards(CancellationToken cancellationToken);

        #endregion Public Methods
    }
}