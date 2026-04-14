using ArtifactsMMO.NET.Objects.Characters;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.MyCharacter.Fight
{
    /// <summary>
    /// Represents the data related to a character's fight action.
    /// </summary>
    /// <remarks>
    /// This class inherits from <see cref="ActionData"/>.
    /// </remarks>
    public class CharacterFightData : MultiCharacterActionData
    {
        internal CharacterFightData() { }

        [JsonConstructor]
        internal CharacterFightData(Cooldown cooldown, Fight fight, IEnumerable<Character> characters)
            : base(cooldown, characters)
        {
            Fight = fight;
        }

        /// <summary>
        /// Fight details.
        /// </summary>
        public Fight Fight { get; }
    }
}
