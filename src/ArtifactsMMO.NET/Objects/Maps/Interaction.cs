using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Maps
{
    public class Interaction
    {
        [JsonConstructor]
        internal Interaction(MapContent content, Transition transition)
        {
            Content = content;
            Transition = transition;
        }

        public MapContent Content { get; }
        public Transition Transition { get; }
    }
}
