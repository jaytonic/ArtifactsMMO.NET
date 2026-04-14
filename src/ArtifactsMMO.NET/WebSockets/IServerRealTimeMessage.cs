using ArtifactsMMO.NET.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtifactsMMO.NET.WebSockets
{
    public interface IServerRealTimeMessage : IRealTimeMessage
    {
        public NotificationType Type { get; }
    }
}
