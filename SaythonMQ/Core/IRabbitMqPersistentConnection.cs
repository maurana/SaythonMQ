using System;
using RabbitMQ.Client;

namespace SaythonMQ.Core
{
    public interface IRabbitMqPersistentConnection : IDisposable
    {
        bool IsConnected { get; }
        bool TryConnect();
        IModel CreateModel();
    }
}
