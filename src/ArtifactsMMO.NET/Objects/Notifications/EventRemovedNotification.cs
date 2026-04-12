using ArtifactsMMO.NET.Enums;
using ArtifactsMMO.NET.Objects.Events;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Notifications
{
    /// <summary>
    /// Notification about a removed event
    /// </summary>
    public class EventRemovedNotification : ServerNotification<ActiveEvent>
    {

        /// <summary>
        /// Construct a new event removed notification
        /// </summary>
        /// <param name="type">Notification type</param>
        /// <param name="data">Active event</param>
        [JsonConstructor]
        public EventRemovedNotification(NotificationType type, ActiveEvent data)
            : base(type, data)
        {
        }
    }
}
