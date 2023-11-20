using Events.model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.model
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options) : base(options) { }

        public DbSet<Hall> Halls { get; set; }
        public DbSet<Inviter> Inviters { get; set; }
        public DbSet<InventionEvent> InventionEvents { get; set; }
        public DbSet<InventionMenu> InventionMenus { get; set; }
        public DbSet<Menu> Menus { get; set; }

    }
}
