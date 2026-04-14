using ArtifactsMMO.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Maps
{
    public class Access
    {
        [JsonConstructor]
        internal Access(AccessType type, IEnumerable<Condition> conditions)
        {
            Type = type;
            Conditions = conditions;
        }

        public AccessType Type { get; }
        public IEnumerable<Condition> Conditions { get; }
    }
}
