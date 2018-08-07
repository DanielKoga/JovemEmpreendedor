using KogaTech.Domain.Core.Commands;
using KogaTech.Domain.Core.Events;

namespace KogaTech.Domain.Core.Bus
{
    public interface IBus
    {
        void SendCommand<T>(T theCommand) where T : Command;
        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}
