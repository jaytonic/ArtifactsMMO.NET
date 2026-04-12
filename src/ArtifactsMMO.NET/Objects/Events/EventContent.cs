using ArtifactsMMO.NET.Enums;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Events
{
    /// <summary>
    /// Content of the event
    /// </summary>
    public class EventContent
    {
        internal EventContent()
        {

        }

        [JsonConstructor]
        internal EventContent(EventContentType type, string code)
        {
            Type = type;
            Code = code;
        }

        /// <summary>
        /// Type of the event.
        /// </summary>
        public EventContentType Type { get; }

        /// <summary>
        /// Code content.
        /// </summary>
        public string Code { get; }
    }
}
