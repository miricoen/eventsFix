using Event.DAL.Interface;
using Events.model;
using Events.model.Model;

namespace Event.DAL
{
    public class EventRepository: IEventRepository
    {
        readonly EventContext _EventContext;
        public EventRepository(EventContext eventContext)
        {
            _EventContext = eventContext;
        }
        public List<InventionEvent> GetInventionEvent()
        {
            return _EventContext.InventionEvents.ToList();
        }

    }
}