using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Maps
{
    /// <summary>
    /// Map details
    /// </summary>
    public class Map
    {
        internal Map() { }

        [JsonConstructor]
        internal Map(int mapId, string name, string skin, int x, int y, string layer, Access access, Interaction interactions)
        {
            MapId = mapId;
            Name = name;
            Skin = skin;
            X = x;
            Y = y;
            Layer = layer;
            Access = access;
            Interactions = interactions;
        }

        public int MapId { get; }

        /// <summary>
        /// Name of the map.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Skin of the map.
        /// </summary>
        public string Skin { get; }

        /// <summary>
        /// Position X of the map.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Position Y of the map.
        /// </summary>
        public int Y { get; }
        public string Layer { get; }
        public Access Access { get; }
        public Interaction Interactions { get; }
    }
}
