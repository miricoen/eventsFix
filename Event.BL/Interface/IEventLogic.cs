using Events.model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.BL.Interface
{
    public interface IEventLogic
    {
        public List<InventionEvent> GetInventionEvent();
    }
}
