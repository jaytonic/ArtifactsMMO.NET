using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Achievements
{
    public class RewardItem
    {
        [JsonConstructor]
        internal RewardItem(string code, int quantity)
        {
            Code = code;
            Quantity = quantity;
        }

        public string Code { get; }
        public int Quantity { get; }
    }
}
