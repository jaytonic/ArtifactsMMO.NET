using ArtifactsMMO.NET.Objects.Loot;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.XPath;

namespace ArtifactsMMO.NET.Objects.MyCharacter.Fight
{
    public class CharacterMultiFightResult
    {
        [JsonConstructor]
        internal CharacterMultiFightResult(string characterName, int xp, int gold, IEnumerable<Drop> drops, int finalHp)
        {
            CharacterName = characterName;
            Xp = xp;
            Gold = gold;
            Drops = drops;
            FinalHp = finalHp;
        }

        public string CharacterName { get; }
        public int Xp { get; }
        public int Gold { get; }
        public IEnumerable<Drop> Drops { get; }
        public int FinalHp { get; }
    }
}
