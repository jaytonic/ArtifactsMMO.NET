using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Effects
{
    public class StorageEffect
    {
        [JsonConstructor]
        internal StorageEffect(string code, int value) {
            Code = code;
            Value = value;
        }

        public string Code { get; }
        public int Value { get; }
    }
}
