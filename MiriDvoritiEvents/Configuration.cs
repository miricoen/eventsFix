using Event.BL;
using Event.BL.Interface;
using Event.DAL;
using Event.DAL.Interface;

namespace MiriDvoritiEvents
{
    public static class ConfigurationService
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
             services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IEventLogic, EventLogic>();
        }
    }
}
