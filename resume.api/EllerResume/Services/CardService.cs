using Controllers.Controllers.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Controllers.Services
{
    /// <summary>
    /// The card service.
    /// </summary>
    /// <seealso cref="ICardService"/>
    public class CardService
        : ICardService
    {
        #region Public Methods

        public Task<CardsResponse> GetCards(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods
    }
}