using ArtifactsMMO.NET.Exceptions;
using ArtifactsMMO.NET.Objects.Items;
using ArtifactsMMO.NET.Validators;

namespace ArtifactsMMO.NET.Requests
{
    /// <summary>
    /// Request to take an item from your bank and put it in the character's inventory.
    /// </summary>
    public class WithdrawBankRequest : IRequest
    {
        private static readonly IValidator<WithdrawBankRequest> _validator = new WithdrawBankRequestValidator();

        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawBankRequest"/> class.
        /// </summary>
        /// <exception cref="ItemCodeHasDisallowedCharacters">Thrown when <paramref name="code"/> contains not allowed characters. Should match pattern ^[a-zA-Z0-9_-]+$</exception>
        /// <exception cref="DisallowedQuantity">Thrown when <paramref name="quantity"/> is less then 1.</exception>
        public WithdrawBankRequest(params SimpleItem[] items)
        {
            Items = items;

            _validator.Validate(this);
        }

        public SimpleItem[] Items { get; }
    }
}
