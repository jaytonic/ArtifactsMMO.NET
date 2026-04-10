using ArtifactsMMO.NET.Objects.Characters;
using System.Collections.Generic;

namespace ArtifactsMMO.NET.Objects.MyCharacter
{
    /// <summary>
    /// Represents the base class for action data in the game, 
    /// encapsulating the details related to a specific action, 
    /// including cooldown information and the character performing the action.
    /// </summary>
    public abstract class MultiCharacterActionData
    {
        protected MultiCharacterActionData() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionData"/> class with specified cooldown and character.
        /// </summary>
        /// <param name="cooldown">The cooldown period for the action.</param>
        /// <param name="characters">The character performing the action.</param>
        protected MultiCharacterActionData(Cooldown cooldown, IEnumerable<Character> characters)
        {
            Cooldown = cooldown;
            Characters = characters;
        }

        /// <summary>
        /// Cooldown information associated with the action.
        /// </summary>
        public Cooldown Cooldown { get; }

        /// <summary>
        /// Character that is performing the action.
        /// </summary>
        public IEnumerable<Character> Characters { get; }
    }
}
