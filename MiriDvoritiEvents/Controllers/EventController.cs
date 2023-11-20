using Event.BL.Interface;
using Events.model.Model;
using Microsoft.AspNetCore.Mvc;

namespace MiriDvoritiEvents.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class eventController : ControllerBase
        {
            readonly IEventLogic _EventLogic;

            public eventController(IEventLogic eventLogic)
            {
                _EventLogic = eventLogic;
            }

            [HttpGet]
            public List<InventionEvent> Get()
            {
                return _EventLogic.GetInventionEvent();
            }

        }
    }

