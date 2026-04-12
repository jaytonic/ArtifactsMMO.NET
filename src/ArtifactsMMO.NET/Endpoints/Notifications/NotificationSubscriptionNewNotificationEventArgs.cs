using ArtifactsMMO.NET.Objects.Notifications;
using ArtifactsMMO.NET.WebSockets;
using System;

namespace ArtifactsMMO.NET.Endpoints.Notifications
{
    /// <summary>
    /// Represent a new notification from the server
    /// </summary>
    public class NotificationSubscriptionNewNotificationEventArgs : EventArgs
    {
        internal NotificationSubscriptionNewNotificationEventArgs(IServerRealTimeMessage notification)
        {
            Notification = notification;
        }

        /// <summary>
        /// The notification of the server
        /// </summary>
        public IServerRealTimeMessage Notification { get; }
    }
}
