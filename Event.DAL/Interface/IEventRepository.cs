using Events.model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.DAL.Interface
{
    public interface IEventRepository
    {
        public List<InventionEvent> GetInventionEvent();

    }
}
