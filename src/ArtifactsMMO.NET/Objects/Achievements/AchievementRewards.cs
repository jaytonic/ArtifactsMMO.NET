using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Achievements
{
    /// <summary>
    /// Achievement rewards
    /// </summary>
    public class AchievementRewards
    {
        internal AchievementRewards() { }

        [JsonConstructor]
        internal AchievementRewards(int gold, IEnumerable<RewardItem> items)
        {
            Gold = gold;
            Items = items;
        }

        /// <summary>
        /// Gold rewards.
        /// </summary>
        public int Gold { get; }
        public IEnumerable<RewardItem> Items { get; }
    }
}
