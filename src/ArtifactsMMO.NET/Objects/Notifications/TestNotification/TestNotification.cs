using System.Text.Json.Serialization;
using ArtifactsMMO.NET.Enums;

namespace ArtifactsMMO.NET.Objects.Notifications.TestNotification
{
    /// <summary>
    /// Test notification from the server
    /// This get emitted every 60 seconds, for test purpose
    /// </summary>
    public class TestNotification : ServerNotification<TestNotificationData>
    {

        /// <summary>
        /// Create a new test notification
        /// </summary>
        /// <param name="type">The notification type</param>
        /// <param name="data">The test message</param>
        [JsonConstructor]
        public TestNotification(NotificationType type, TestNotificationData data)
            : base(type, data)
        {
        }
    }
}
