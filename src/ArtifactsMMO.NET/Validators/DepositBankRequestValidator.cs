using ArtifactsMMO.NET.Exceptions;
using ArtifactsMMO.NET.Objects.Items;
using ArtifactsMMO.NET.Requests;
using ArtifactsMMO.NET.Validators.Static;
using System.Linq;

namespace ArtifactsMMO.NET.Validators
{
    internal class DepositBankRequestValidator : IValidator<DepositBankRequest>
    {
        public void Validate(DepositBankRequest depositBankRequest)
        {
            if (depositBankRequest.Items.Count() == 0)
            {
                throw new DisallowedQuantity();
            }

            foreach (SimpleItem item in depositBankRequest.Items)
            {
                if (!AlphaNumericUnderscoreHyphenValidator.IsValid(item.Code))
                {
                    throw new ItemCodeHasDisallowedCharacters();
                }

                if (!QuantityValidator.IsValid(item.Quantity))
                {
                    throw new DisallowedQuantity();
                }
            }
        }
    }
}
