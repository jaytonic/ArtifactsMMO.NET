using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Notifications.TestNotification
{
    public class TestNotificationData
    {
        [JsonConstructor]
        public TestNotificationData(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}
