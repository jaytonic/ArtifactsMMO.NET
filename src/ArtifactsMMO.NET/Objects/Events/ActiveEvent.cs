using ArtifactsMMO.NET.Objects.Maps;
using System;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Events
{
    /// <summary>
    /// Game active event details
    /// </summary>
    public class ActiveEvent
    {
        internal ActiveEvent() { }

        [JsonConstructor]
        internal ActiveEvent(string name, string code, Map map, Map previousMap, long duration,
            DateTimeOffset expiration, DateTimeOffset createdAt)
        {
            Name = name;
            Code = code;
            Map = map;
            PreviousMap = previousMap;
            Duration = duration;
            Expiration = expiration;
            CreatedAt = createdAt;
        }

        /// <summary>
        /// Name of the event.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Code of the event. This is the event's unique identifier (ID).
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Map of the event.
        /// </summary>
        public Map Map { get; }
        public Map PreviousMap { get; }

        /// <summary>
        /// Duration in minutes.
        /// </summary>
        public long Duration { get; }

        /// <summary>
        /// Expiration datetime.
        /// </summary>
        public DateTimeOffset Expiration { get; }

        /// <summary>
        /// Start datetime.
        /// </summary>
        public DateTimeOffset CreatedAt { get; }
    }
}
