using ArtifactsMMO.NET.Enums;
using ArtifactsMMO.NET.Objects.Loot;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.MyCharacter.Fight
{
    /// <summary>
    /// Fight details.
    /// </summary>
    public class Fight
    {
        internal Fight() { }

        [JsonConstructor]
        internal Fight(FightResult result, int turns, string opponent, IReadOnlyCollection<string> logs,
            IEnumerable<CharacterMultiFightResult> characters)
        {
            Turns = turns;
            Opponent = opponent;
            Logs = logs;
            Result = result;
            Characters = characters;
        }

        /// <summary>
        /// Numbers of the turns of the combat.
        /// </summary>
        public int Turns { get; }
        public string Opponent { get; }


        /// <summary>
        /// The fight logs.
        /// </summary>
        public IReadOnlyCollection<string> Logs { get; }

        /// <summary>
        /// The result of the fight.
        /// </summary>
        public FightResult Result { get; }
        public IEnumerable<CharacterMultiFightResult> Characters { get; }
    }
}
