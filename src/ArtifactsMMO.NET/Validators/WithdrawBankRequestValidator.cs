using ArtifactsMMO.NET.Exceptions;
using ArtifactsMMO.NET.Objects.Items;
using ArtifactsMMO.NET.Requests;
using ArtifactsMMO.NET.Validators.Static;
using System.Linq;

namespace ArtifactsMMO.NET.Validators
{
    internal class WithdrawBankRequestValidator : IValidator<WithdrawBankRequest>
    {
        public void Validate(WithdrawBankRequest withdrawBankRequest)
        {
            if (withdrawBankRequest.Items.Count() == 0)
            {
                throw new DisallowedQuantity();
            }

            foreach (SimpleItem item in withdrawBankRequest.Items)
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
