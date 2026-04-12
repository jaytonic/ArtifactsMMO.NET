using ArtifactsMMO.NET.Enums;
using ArtifactsMMO.NET.Objects.GrandExchange;
using System.Text.Json.Serialization;

namespace ArtifactsMMO.NET.Objects.Notifications
{
    /// <summary>
    /// Notification about a grand exchange new order
    /// </summary>
    public class GrandExchangeNewOrderNotification : ServerNotification<GrandExchangeOrder>
    {

        /// <summary>
        /// Construct a new grand exchange new order notification
        /// </summary>
        /// <param name="type">Notification type</param>
        /// <param name="data">Thew new grand exchange order</param>
        [JsonConstructor]
        public GrandExchangeNewOrderNotification(NotificationType type, GrandExchangeOrder data)
            : base(type, data)
        {
        }
    }
}
