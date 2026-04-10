using ArtifactsMMO.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Achievements
{
    /// <summary>
    /// Objective that must be completed
    /// </summary>
    public class AchievementObjective
    {
        internal AchievementObjective() { }

        [JsonConstructor]
        internal AchievementObjective(AchievementObjectiveType type, string target, int total)
        {
            Type = type;
            Target = target;
            Total = total;
        }

        public AchievementObjectiveType Type { get; }
        public string Target { get; }
        public int Total { get; }
    }
}
