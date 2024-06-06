using Events = EncantoPaisa.DAL.Entities.Events;
using EncantoPaisa.DAL.Entities;

namespace EncantoPaisa.Domain.Interfaces
{
    public interface IEventsService
    {
        Events CreateEvents(Events events);
    }
}


