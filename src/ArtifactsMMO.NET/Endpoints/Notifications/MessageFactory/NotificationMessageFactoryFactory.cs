using ArtifactsMMO.NET.Objects.Notifications;
using ArtifactsMMO.NET.WebSockets;
using System.Collections.Generic;

namespace ArtifactsMMO.NET.Endpoints.Notifications.MessageFactory
{
    internal class NotificationMessageFactoryFactory : MessageFactoryFactory<IServerRealTimeMessage>
    {
        protected override IEnumerable<IMessageFactory<IServerRealTimeMessage>> GetFactories()
        {
            return new IMessageFactory<IServerRealTimeMessage>[]
            {
                new EventSpawnMessageFactory(),
                new EventRemovedMessageFactory(),
                new GrandExchangeNewOrderMessageFactory(),
                new GrandExchangeSellMessageFactory(),
                new AchievementUnlockMessageFactory(),
                new TestSpawnMessageFactory()
            };
        }
    }
}
