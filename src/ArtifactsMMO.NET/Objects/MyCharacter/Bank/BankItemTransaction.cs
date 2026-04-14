using ArtifactsMMO.NET.Objects.Characters;
using ArtifactsMMO.NET.Objects.Items;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.MyCharacter.Bank
{
    /// <summary>
    /// Represents the data related to a character's bank item transaction action.
    /// </summary>
    /// <remarks>
    /// This class inherits from <see cref="ActionData"/>.
    /// </remarks>
    public class BankItemTransaction : ActionData
    {
        internal BankItemTransaction() { }

        [JsonConstructor]
        internal BankItemTransaction(Cooldown cooldown, IReadOnlyCollection<SimpleItem> items, IReadOnlyCollection<SimpleItem> bank,
            Character character)
            : base(cooldown, character)
        {
            Items = items;
            Bank = bank;
        }

        /// <summary>
        /// Item details.
        /// </summary>
        public IReadOnlyCollection<SimpleItem> Items { get; }

        /// <summary>
        /// Items in your banks.
        /// </summary>
        public IReadOnlyCollection<SimpleItem> Bank { get; }
    }
}
