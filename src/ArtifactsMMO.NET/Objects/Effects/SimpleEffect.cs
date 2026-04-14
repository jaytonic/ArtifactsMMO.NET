using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Effects
{
    /// <summary>
    ///  Simple Effect details
    /// </summary>
    public class SimpleEffect
    {
        internal SimpleEffect() { }

        [JsonConstructor]
        internal SimpleEffect(string code, int value, string description)
        {
            Code = code;
            Value = value;
            Description = description;
        }

        /// <summary>
        /// Effect code.
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Effect value.
        /// </summary>
        public int Value { get; }
        public string Description { get; }
    }
}
