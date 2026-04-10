using ArtifactsMMO.NET.Exceptions;
using ArtifactsMMO.NET.Objects.Items;
using ArtifactsMMO.NET.Validators;
using System.Collections.Generic;

namespace ArtifactsMMO.NET.Requests
{
    /// <summary>
    /// Request to deposit an item in a bank.
    /// </summary>
    public class DepositBankRequest : IRequest
    {
        private readonly static IValidator<DepositBankRequest> _validator = new DepositBankRequestValidator();


        /// <summary>
        /// Initializes a new instance of the <see cref="DepositBankRequest"/> class.
        /// </summary>
        /// <exception cref="ItemCodeHasDisallowedCharacters">Thrown when <paramref name="code"/> contains not allowed characters. Should match pattern ^[a-zA-Z0-9_-]+$</exception>
        /// <exception cref="DisallowedQuantity">Thrown when <paramref name="quantity"/> is less then 1.</exception>
        public DepositBankRequest(params SimpleItem[] items)
        {
            Items = items;
            _validator.Validate(this);
        }

        public IEnumerable<SimpleItem> Items { get; }
    }
}
