using Event.BL.Interface;
using Event.DAL.Interface;
using Events.model.Model;

namespace Event.BL
{
    
    public class EventLogic: IEventLogic
    {
        readonly IEventRepository _EventRepository;

        public EventLogic(IEventRepository Repository)
        {
            _EventRepository = Repository;
        }
        public List<InventionEvent> GetInventionEvent()
        {
            return _EventRepository.GetInventionEvent();
        }

    }
}