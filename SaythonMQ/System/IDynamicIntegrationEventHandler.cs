using System.Threading.Tasks;

namespace SaythonMQ.System
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
