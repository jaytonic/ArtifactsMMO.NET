using ArtifactsMMO.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Maps
{
    public class Condition
    {


        [JsonConstructor]
        internal Condition( string code, Operator @operator, int value)
        {
            Code = code;
            Operator = @operator;
            Value = value;
        }

        public string Code { get; }
        public Operator Operator { get; }
        public int Value { get; }
    }
}
