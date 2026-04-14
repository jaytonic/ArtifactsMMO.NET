using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Events
{
    /// <summary>
    /// Event map details
    /// </summary>
    public class EventMap
    {
        internal EventMap() { }

        [JsonConstructor]
        internal EventMap(int mapId, int x, int y, string layer, string skin)
        {
            MapId = mapId;
            X = x;
            Y = y;
            Layer = layer;
            Skin = skin;
        }

        /// <summary>
        /// ID of the map
        /// </summary>
        public int MapId { get; }

        /// <summary>
        /// Position X of the map.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Position Y of the map.
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Layer of the map
        /// </summary>
        public string Layer { get; }

        /// <summary>
        /// Skin of the map
        /// </summary>
        public string Skin { get; }
    }
}
