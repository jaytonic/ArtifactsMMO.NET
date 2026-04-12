using ArtifactsMMO.NET.Exceptions;
using ArtifactsMMO.NET.Requests;
using ArtifactsMMO.NET.Validators.Static;

namespace ArtifactsMMO.NET.Validators
{
    internal class NpcSellItemRequestValidator : IValidator<NpcSellItemRequest>
    {
        public void Validate(NpcSellItemRequest sellItemRequest)
        {
            if (!AlphaNumericUnderscoreHyphenValidator.IsValid(sellItemRequest.Code))
            {
                throw new ItemCodeHasDisallowedCharacters();
            }

            if (!QuantityValidator.IsValid(sellItemRequest.Quantity))
            {
                throw new DisallowedQuantity();
            }
        }
    }
}
