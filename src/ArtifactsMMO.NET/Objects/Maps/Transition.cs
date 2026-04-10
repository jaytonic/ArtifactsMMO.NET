using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Maps
{
    public class Transition
    {
        [JsonConstructor]
        internal Transition(int mapId, int x, int y, string layer, IEnumerable<Condition>? conditions)
        {
            MapId = mapId;
            X = x;
            Y = y;
            Layer = layer;
            Conditions = conditions;
        }

        public int MapId { get; }
        public int X { get; }
        public int Y { get; }
        public string Layer { get; }
        public IEnumerable<Condition> Conditions { get; }
    }
}
