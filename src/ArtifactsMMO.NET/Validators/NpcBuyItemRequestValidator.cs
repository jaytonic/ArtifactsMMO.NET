using ArtifactsMMO.NET.Exceptions;
using ArtifactsMMO.NET.Requests;
using ArtifactsMMO.NET.Validators.Static;

namespace ArtifactsMMO.NET.Validators
{
    internal class NpcBuyItemRequestValidator : IValidator<NpcBuyItemRequest>
    {
        public void Validate(NpcBuyItemRequest buyItemRequest)
        {
            if (!AlphaNumericUnderscoreHyphenValidator.IsValid(buyItemRequest.Code))
            {
                throw new ItemCodeHasDisallowedCharacters();
            }

            if (!QuantityValidator.IsValid(buyItemRequest.Quantity))
            {
                throw new DisallowedQuantity();
            }
        }
    }
}
